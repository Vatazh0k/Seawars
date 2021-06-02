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
using Seawars.Infrastructure.Validation;

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
            RegisterCommand = new Command(RegisterCommandAction, x=> true);
            LoginCommand = new Command(LoginCommandAction, x => true);
        }

        private void LoginCommandAction(object obj)
        {
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
                ShowInformationMessage("This Username is already used... Try another");

                return;
            }
            if (Passwrod != RepeatedPassword)
            {
                ShowInformationMessage("Passwrods are diffrent. . .");

                return;
            }



        }

        private void ShowInformationMessage(string message) => MessageBox.Show(message, "Error", MessageBoxButton.OK, MessageBoxImage.Information);
    }
}
