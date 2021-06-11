using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Seawars.Interfaces.Game;
using Seawars.WPF.Common;

namespace Seawars.WPF.ViewModels
{
    public class BattleGroundWithUserViewModel : ViewModelBase, IBattleGround
    {
        #region Data
        private string _attackHint = "A1";
        private int _enemyShipsCount = 10;
        private int _missCounter = 0;

        public string AttackHint
        {
            get => _attackHint;
            set => Set(ref _attackHint, value);
        }

        public int EnemyShipsCount
        {
            get => _enemyShipsCount;
            set => Set(ref _enemyShipsCount, value);
        }

        public int MissCounter
        {
            get => _missCounter;
            set => Set(ref _missCounter, value);
        }
        #endregion

        public ICommand AttackCommand { get; set; }
    }
}
