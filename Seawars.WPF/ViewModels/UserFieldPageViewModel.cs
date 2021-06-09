using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Seawars.WPF.ViewModels
{
    public class UserFieldPageViewModel
    {
        public ICommand ShipsAutoGeneration { get; }
        public ICommand CleanField { get; }
        public ICommand ReadyCommand { get; }
    }
}
