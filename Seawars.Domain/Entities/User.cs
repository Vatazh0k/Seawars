using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Seawars.Interfaces.Entities;

namespace Seawars.Domain.Entities
{
    public class User : IEntity
    {
        [Key]
        public int Id { get; }
        public string  UserName { get; set; }
        public string Password { get; set; }
        public int GamesWithComputerCount { get; set; }
        public int TotalGamesCount { get; set; }
        public int CountOfWonGames { get; set; }

        public List<Games> Games { get; set; }
    }
}
