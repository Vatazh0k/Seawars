using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seawars.Interfaces.Game
{
    public interface IBattleGround
    {
        public string AttackHint { get; set; }

        public int EnemyShipsCount { get; set; }
        public int MissCounter { get; set; }
    }
}
