using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Seawars.DAL.GamesBase;
using Seawars.Domain.Models;
using Seawars.Infrastructure.Encryption;
using Seawars.Interfaces.Services;

namespace Seawars.WebApi.Clients.Connection
{
    public class GameConnection : IConnection
    {
        public string CreateGame()
        {
            Collection collection = Collection.GetGame();

            int Id = StopWatch.TotalGamesCounnt;

            StopWatch.TotalGamesCounnt++;

            var CryptedId = TripleDes.Encrypted(Id);

            collection.Games.Add(Id, new Game(CryptedId));

            if(StopWatch.IsActive is not true) StopWatch.StartTimer();

            var resault = JsonConvert.SerializeObject(collection.Games[Id]);

            return resault;
           
        }

        public string JoinGame(string Id)
        {
            throw new NotImplementedException();
        }

    }
}
