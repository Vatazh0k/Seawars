using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seawars.WPF.Authorization.Model
{
    public class Steps
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int StepNumber { get; set; }
        public Step? Step { get; set; }

        public Steps()
        {
            
        }

        public Steps(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public Steps(int X, int Y, int StepNumber)
        {
            this.X = X;
            this.Y = Y;
            this.StepNumber = StepNumber;
        }
    }

    public enum Step
    {
        Enimy = 1,
        Your = 2,
    }
}
