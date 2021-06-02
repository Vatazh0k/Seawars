using System;
using System.Security.AccessControl;
using System.Windows.Input;
using Microsoft.Extensions.Hosting;
using System.Linq;
using System.Windows;
using Seawars.Domain.Entities;
using Seawars.WPF.Common;
using Seawars.WPF.Common.Commands;
using Seawars.WPF.Services;

namespace Seawars.WPF.ViewModels
{
    internal class AuthorizationWindowViewModel : ViewModelBase
    {
        public ICommand RegisterCommand { get; set; }
        public ICommand LoginCommand { get; set; }

        private string _name;
        private string _username;
        private string _passwords;
        private string _repeatedPassword;

        public string RepeatedPassword
        {
            get => _repeatedPassword;
            set => Set(ref _repeatedPassword, value);
        }
        public string Passwrod
        {
            get => _passwords;
            set => Set(ref _passwords, value);
        }
        public string Username
        {
            get => _username;
            set => Set(ref _username, value);
        }
        public string Name
        {
            get => _name;
            set => Set(ref _name, value);
        }

        public AuthorizationWindowViewModel()
        {
            RegisterCommand = new Command(RegisterCommandAction, x=>true);
            LoginCommand = new Command(LoginCommandAction, x => true);
        }

        private void LoginCommandAction(object obj)
        {
        }
        private void RegisterCommandAction(object obj)
        {
            var Users = ServicesLocator.UserRepository.GetAll();
            var SameUserExit = Users.Exists(x => x.UserName == Username);

            if (SameUserExit)//Change validation 
            {
                MessageBox.Show("This Username is already used... Try another", "Error", MessageBoxButton.OK, MessageBoxImage.Information );

                return;
            }
        }
    }
}
