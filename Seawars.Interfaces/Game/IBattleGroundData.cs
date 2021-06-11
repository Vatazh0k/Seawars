using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Seawars.Interfaces.Game
{
    public interface IBattleGroundData
    {
        public string AttackHint { get; set; }
        public int EnemyShipsCount { get; set; }
        public int MissCounter { get; set; }

        ICommand AttackCommand { get; set; }
    }
}
