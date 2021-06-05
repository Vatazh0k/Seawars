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

namespace Seawars.WPF.ViewModels
{
    public class UserPageViewModel : ViewModelBase
    {
        public string Name { get;  } = $"Name:  {App.CuurentUser.Name}";
        public string Username { get; } = $"Username:  {App.CuurentUser.UserName}";
        public string TotalGamesCount { get; } = $"Total games count:  {App.CuurentUser.TotalGamesCount}";
        public string GamesWithComputer { get; } = $"Games with computer count:  {App.CuurentUser.GamesWithComputer}"; 
        public string CountOfWonGames { get; } = $"Win games count:  {App.CuurentUser.CountOfWonGames}";


        public UserPageViewModel()
        {
            
        }

       
    }
}
