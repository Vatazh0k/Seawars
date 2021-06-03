using Seawars.WPF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seawars.WPF.Common.Commands
{
    class DeleteAccountCommand : BaseCommand
    {
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            
            var game = ServicesLocator.GameRepository.GetAll().FirstOrDefault(x => x.User == App.CuurentUser);
            var steps = ServicesLocator.StepRepository.GetAll().Where(x => x.Game == game).Select(x => x);
            context.Steps.RemoveRange(steps);
            context.Games.Remove(game);
            context.Users.Remove(user);
            context.SaveChanges();
        }
    }
}
