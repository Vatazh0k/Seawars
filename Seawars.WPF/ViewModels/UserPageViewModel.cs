using Seawars.WPF.Common;
using Seawars.WPF.Common.Commands;
using Seawars.WPF.Services;
using Seawars.WPF.View.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Seawars.Domain.Entities;
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

        public UserPageViewModel()
        {

        }

       
    }
}
