using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Seawars.WPF.Common;

namespace Seawars.WPF.ViewModels
{
    class ConnectionPageViewModel : ViewModelBase
    {
        public ICommand PlayWithUserCommand { get; }
        public ICommand StartGameCommand { get; }
    }
}
