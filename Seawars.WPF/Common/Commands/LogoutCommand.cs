using Seawars.WPF.Services;
using Seawars.WPF.View.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seawars.WPF.Common.Commands
{
    class LogoutCommand : BaseCommand
    {
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            ServicesLocator.PageService.SetPage<LoginPage>(new LoginPage());
            ServicesLocator.AuthorizationWindowViewModel.Passwrod = new ("*");
            ServicesLocator.AuthorizationWindowViewModel.RepeatedPassword = new ("*");
            ServicesLocator.AuthorizationWindowViewModel.Name = string.Empty;
        }
    }
}
