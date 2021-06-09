using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seawars.Application.GameLogic;

namespace Seawars.Domain.Models
{
    public class Game
    {
        public string CryptedGameId { get; set; }

        public Field FirstUserField { get; set; } = new Field();
        public Field SecondUserField { get; set; } = new Field();

        public bool IsFirstUserMove { get; set; } = true;
        public bool IsFirstUserReadyToStartGame { get; set; }
        public bool IsSecondUserReadyToStartGame { get; set; }
        public bool IsGameOver { get; set; }
        public bool IsFirstUserWin { get; set; }
        public bool DidEnemyConnect { get; set; } = false;
        public bool IsGameWithComputer { get; set; } = true;


        public Field this[int index]
        {
            get => index switch
            {
                1 => FirstUserField,
                2 => SecondUserField,
                { } => null
            };
        }

    }
}
