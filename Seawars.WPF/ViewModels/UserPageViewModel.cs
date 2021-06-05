using Seawars.WPF.Common;
using Seawars.WPF.Common.Commands;
using Seawars.WPF.Services;
using Seawars.WPF.View.Pages;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Seawars.Domain.Entities;
using Seawars.WPF.View.UsersControls;

namespace Seawars.WPF.ViewModels
{
    public class UserPageViewModel : ViewModelBase
    {
        #region Data

        #region Profile
        public string Name { get; } = $"Name:  {App.CuurentUser.Name}";
        public string Username { get; } = $"Username:  {App.CuurentUser.UserName}";
        public string TotalGamesCount { get; } = $"Total games count:  {App.CuurentUser.TotalGamesCount}";
        public string GamesWithComputer { get; } = $"Games with computer count:  {App.CuurentUser.GamesWithComputer}";
        public string CountOfWonGames { get; } = $"Win games count:  {App.CuurentUser.CountOfWonGames}";
        #endregion

        #region View
        private object _CurrentViewControl = new ProfileControl();

        public object CurrentViewControl
        {
            get => _CurrentViewControl;
            set => Set(ref _CurrentViewControl, value);
        }
        #endregion


        #endregion

        #region Commands
        public ICommand StartGameCommand { get; }
        public ICommand ShowStatisticCommand { get; }
        #endregion

        public UserPageViewModel()
        {
            StartGameCommand = new Command(StartGame, x => true);
            ShowStatisticCommand = new Command(ShowStatistic, x => true);
        }

        private void ShowStatistic(object obj)
        {
           
        }

        private void StartGame(object obj)
        {

        }
    }
}
