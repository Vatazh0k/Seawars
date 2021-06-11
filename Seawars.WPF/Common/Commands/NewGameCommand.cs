using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Seawars.WPF.Common.Commands.Base;
using Seawars.WPF.Services;
using Seawars.WPF.View.Pages;
using Seawars.WPF.View.UserControls;
using Seawars.WPF.ViewModels;

namespace Seawars.WPF.Common.Commands
{
    public class NewGameCommand : BaseCommand
    {
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            //Process.Start(Process.GetCurrentProcess().MainModule.FileName);
            //Application.Current.Shutdown();

            ServicesLocator.UserPageViewModel.CurrentViewControl = new ProfileControl();
            //TODO: Reload all viewmodels S.*.Reload(); (App.ReloadGame)
            App.WindowCurrent.Close();
            App.UserProfileWindow.Show();
        }//TODO: add games and steps to db; make game with computer.
    }
}
