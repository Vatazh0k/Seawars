using System;
using System.Configuration;
using System.Windows.Input;
using Seawars.WPF.Services;
using Seawars.WPF.Common;
using Seawars.WPF.Common.Commands.Base;
using Seawars.WPF.View.Pages.Game;
using Seawars.WPF.View.Pages.Game.Connection;

namespace Seawars.WPF.ViewModels
{
    class ConnectionPageViewModel : ViewModelBase
    {
        #region Commands
        public ICommand PlayWithUserCommand { get; }
        public ICommand StartGameCommand { get; }

        public ICommand CreateNewGameCommand { get; }
        public ICommand JoinTheExistGameCommand { get; }
        public ICommand BackCommand { get; }
        #endregion

        #region Game id
        private string _gameId;
        public string GameId
        {
            get => _gameId;
            set => Set(ref _gameId, value);
        }
        #endregion

        #region MyRegion
        private readonly string Path = ConfigurationManager.AppSettings["Url"];

        #endregion

        public ConnectionPageViewModel()
        {
            PlayWithUserCommand = new Command(PlayWithUserCommandAction, x => true);
            StartGameCommand = new Command(StartGameCommandAction, x => true);
            CreateNewGameCommand = new Command(CreateNewGameCommandAction, x=> true);
            JoinTheExistGameCommand = new Command(JoinTheGameCommandAction, x => true);
            BackCommand = new Command(BackCommandAction, x=> true);
        }

        private void PlayWithUserCommandAction(object obj) => ServicesLocator.GamePageService.SetPage(new UsersConnectionPage());
        private void BackCommandAction(object obj) => ServicesLocator.GamePageService.SetPage(new ConnectionPage());


        private void CreateNewGameCommandAction(object obj)
        {
            GameId = string.Empty;

            ServicesLocator.GamePageService.SetPage(new NewGameCreationPage());

            
        }

        private void JoinTheGameCommandAction(object obj)
        {
            GameId = string.Empty;

            ServicesLocator.GamePageService.SetPage(new ExistGameConnectionPage());


        }

        private void StartGameCommandAction(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
