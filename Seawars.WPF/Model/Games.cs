using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seawars.WPF.Authorization.Model
{
    public class Games
    {
        public string Game { get; set; } = "Game";
        public int Number { get; set; }
        public int Id { get; set; }
        public string Hint { get; set; } = "double click to open game details";

        public Games()
        {
            
        }

        public Games(int Number, int Id)
        {
            this.Number = Number;
            this.Id = Id;
        }
    }
}
