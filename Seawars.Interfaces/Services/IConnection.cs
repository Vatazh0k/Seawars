using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seawars.Interfaces.Services
{
    public interface IConnection
    {
        string CreateGame();
        string JoinGame(string Id);
    }
}
