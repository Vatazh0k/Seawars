using Seawars.Domain.Entities;
using Seawars.Infrastructure.Validation;
using Seawars.WPF.Common;
using Seawars.WPF.Common.Commands;
using Seawars.WPF.Services;
using Seawars.WPF.View.Pages;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace Seawars.WPF.ViewModels
{
    internal class AuthorizationPageViewModel : ViewModelBase
    {
        public ICommand RegisterCommand { get; set; }
        public ICommand GoToLoginWindowCommand { get; set; }
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

        public AuthorizationPageViewModel()
        {
            RegisterCommand = new Command(RegisterCommandAction, x=> true);
            GoToLoginWindowCommand = new Command(GoToLoginWindowAction, x => true);
            LoginCommand = new Command(LoginCommandAction, x => true);
        }

        private void GoToLoginWindowAction(object obj) => ServicesLocator.PageService.SetPage(new LoginPage());
        private void ShowInformationMessage(string message) => MessageBox.Show(message, "Error", MessageBoxButton.OK, MessageBoxImage.Information);

        private void LoginCommandAction(object obj)
        {
            if (Validator.NullExist(Username, Passwrod))
            {
                ShowInformationMessage("Please input all fields!");

                return;
            }

            var Users = ServicesLocator.UserRepository.GetAll();

            if (Users.Exists(x => x.UserName == Username) is false)
            {
                ShowInformationMessage($"Username '{Username}' doesnt exist!");

                return;
            }

            if (Users.Exists(x => x.Password == Passwrod) is false)
            {
                ShowInformationMessage($"Incorrect password!");

                return;
            }

            ServicesLocator.PageService.SetPage(new UserPage());

        }
        private void RegisterCommandAction(object obj)
        {
            
            if (Validator.NullExist(Name, Username, Passwrod, RepeatedPassword))
            {
                ShowInformationMessage("Please input all fields!");

                return;
            }
            if (ServicesLocator.UserRepository.GetAll().Exists(x => x.UserName == Username))
            {
                ShowInformationMessage($"This Username '{Username}' is already used... Try another");

                return;
            }
            if (Passwrod != RepeatedPassword)
            {
                ShowInformationMessage("Passwrods are diffrent. . .");

                return;
            }

            ServicesLocator.UserRepository.Add<User>(new User(Username, Name, Passwrod));

            ServicesLocator.PageService.SetPage(new UserPage());

        }

    }
}
