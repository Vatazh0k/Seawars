using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Seawars.Interfaces.Entities;

namespace Seawars.Domain.Entities
{
    public class User : IEntity
    {

        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int? TotalGamesCount { get; set; }
        public int? GamesWithComputer { get; set; }
        public int? CountOfWonGames { get; set; }

        public User()
        {

        }

        public User(string userName, string name, string password)
        {
            UserName = userName;
            Name = name;
            Password = password;
        }
    }
}
