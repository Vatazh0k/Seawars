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
        #region Commands
        public ICommand RegisterCommand { get; set; }
        public ICommand GoToLoginWindowCommand { get; set; }
        public ICommand LoginCommand { get; set; }
        public ICommand BackCommand { get; set; }

        #endregion

        #region Data
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
        #endregion

        public AuthorizationPageViewModel()
        {
            RegisterCommand = new Command(RegisterCommandAction, x=> true);
            GoToLoginWindowCommand = new Command(GoToLoginWindowAction, x => true);
            LoginCommand = new Command(LoginCommandAction, x => true);
            BackCommand = new Command(BackCommandAction, x => true);
        }

        private void BackCommandAction(object obj) => ServicesLocator.PageService.SetPage<AuthorizationPage>(new AuthorizationPage());
        private void GoToLoginWindowAction(object obj) => ServicesLocator.PageService.SetPage<LoginPage>(new LoginPage());

        private MessageBoxResult ErrorMessage(string message) => MessageBox.Show(message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);

        private void LoginCommandAction(object obj)
        {
            var Users = ServicesLocator.UserRepository.GetAll();

             _ = Validator.NullExist(Username, Passwrod) is true

             ? ErrorMessage("Please input all fields!") : Users.Exists(x => x.UserName == Username) is false

             ? ErrorMessage($"Username '{Username}' doesnt exist!") : Users.Exists(x => x.Password == Passwrod) is false

             ? ErrorMessage($"Incorrect password!") : SuccsessLogin($"Wlcome, {Username}!");

        }
        private void RegisterCommandAction(object obj)
        {
            _ = Validator.NullExist(Name, Username, Passwrod, RepeatedPassword) is true

            ? ErrorMessage("Please input all fields!") : ServicesLocator.UserRepository.GetAll().Exists(x => x.UserName == Username) is true

            ? ErrorMessage($"This Username '{Username}' is already used... Try another") : Passwrod != RepeatedPassword 

            ? ErrorMessage("Passwrods are diffrent. . .") : SuccsessRegister("Yout account has been created!");           

        }

        private MessageBoxResult SuccsessLogin(string message)
        {
            ServicesLocator.PageService.SetPage(new UserPage());

            return MessageBoxResult.OK;
        }
        private MessageBoxResult SuccsessRegister(string message)
        {
            ServicesLocator.UserRepository.Add<User>(new User(Username, Name, Passwrod));

            ServicesLocator.PageService.SetPage(new UserPage());

            return MessageBoxResult.OK;
        }

    }
}
