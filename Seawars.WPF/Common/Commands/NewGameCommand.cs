using Seawars.WPF.Common.Commands.Base;
using Seawars.WPF.Services;
using Seawars.WPF.View.UserControls;

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
        }//TODO: make game with computer.
    }
} 
