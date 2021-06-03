using Seawars.WPF.View.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seawars.WPF.Common.Commands
{
    class SowRulesCommand : BaseCommand
    {
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter) => new RulesWindow().ShowDialog();
    }
}
