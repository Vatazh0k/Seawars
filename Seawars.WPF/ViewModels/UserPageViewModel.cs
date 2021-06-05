using Seawars.WPF.Common;
using Seawars.WPF.Common.Commands;
using Seawars.WPF.Services;
using Seawars.WPF.View.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Seawars.DAL.SqlServer.Repositories;
using Seawars.Domain.Entities;
using Seawars.WPF.Authorization.Model;
using Seawars.WPF.Authorization.View.UserControls;
using Seawars.WPF.View.UserControls;

namespace Seawars.WPF.ViewModels
{
    public class UserPageViewModel : ViewModelBase
    {
        #region Profile data
        public string Name => $"Name:  {App.CuurentUser.Name}";
        public string Username => $"Username:  {App.CuurentUser.UserName}";
        public string TotalGamesCount => $"Total games count:  {App.CuurentUser.TotalGamesCount}";
        public string GamesWithComputer => $"Games with computer count:  {App.CuurentUser.GamesWithComputer}";
        public string CountOfWonGames => $"Win games count:  {App.CuurentUser.CountOfWonGames}";

        #endregion

        #region View
        private object _CurrentViewControl;
        public object CurrentViewControl
        {
            get => _CurrentViewControl;
            set => Set(ref _CurrentViewControl, value);
        }
        #endregion

        #region Collections

        private ObservableCollection<Games> _Games;

        public ObservableCollection<Games> Games
        {
            get => _Games;
            set => Set(ref _Games, value);
        }

        private ObservableCollection<Steps> _Steps;

        public ObservableCollection<Steps> Steps
        {
            get => _Steps;
            set => Set(ref _Steps, value);
        }

        #endregion

        #region DataGrid

        public Games SelectedGame { get; set; }
        #endregion

        #region Commands

        public ICommand ShowStatisticCommand { get; }
        public ICommand StartGameCommand { get; }
        public ICommand BackCommand { get; }
        public ICommand GameDetailsCommand { get; }
        
        #endregion

        public UserPageViewModel()
        {
            ShowStatisticCommand = new Command(ShowStatistic, x => true);
            StartGameCommand = new Command(StartGame, x => true);
            BackCommand = new Command(Back, x => true);
            GameDetailsCommand = new Command(GameDetails, x => true);
        }

        private void Back(object obj) =>
            _ = CurrentViewControl is GamesStatisticControl
                ? CurrentViewControl = new ProfileControl()
                : CurrentViewControl = new GamesStatisticControl();

        private void GameDetails(object obj)
        {
            var steps = ServicesLocator.StepRepository
                .GetAll()
                .Where(x => x.Game.Id == SelectedGame.Id)
                .Select((x, y) => new Steps(x.X, x.Y, y + 1, x.Move))
                .ToList();

            Steps = new ObservableCollection<Steps>(steps);

            CurrentViewControl = new StepsStatisticControl();
        }

        private void ShowStatistic(object obj)
        {
            var games = ServicesLocator.GameRepository
                .GetAll()
                .Where(x => x.User.Id == App.CuurentUser.Id)
                .Select((x,y) => new Games(y+1, x.Id))
                .ToList();

                Games = new ObservableCollection<Games>(games);

                CurrentViewControl = new GamesStatisticControl();

        }

        private void StartGame(object obj)
        {
            
        }
    }
}
