using Seawars.WPF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Seawars.WPF.Base.Commands;

namespace Seawars.WPF.Common.Commands
{
    class DeleteAccountCommand : BaseCommand
    {
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            var res = MessageBox.Show("Are you sure to delete you account?", " ", MessageBoxButton.YesNo, MessageBoxImage.Information);

            if (res == MessageBoxResult.No) return;                
            
            var game = ServicesLocator.GameRepository.GetAll().FirstOrDefault(x => x.User == App.CuurentUser);
            var steps = ServicesLocator.StepRepository.GetAll().Where(x => x.Game == game).Select(x => x).ToList();
            ServicesLocator.StepRepository.DeleteRange(steps);
            ServicesLocator.GameRepository.Delete(game);
            ServicesLocator.UserRepository.Delete(App.CuurentUser);
            ServicesLocator.Repository.Save();

            new LogoutCommand().Execute(null);
        }
    }
}
