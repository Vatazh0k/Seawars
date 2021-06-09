using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seawars.Domain.Models;

namespace Seawars.DAL.GamesBase
{
    public class Collection
    {
        public Dictionary<int, Game> Games { get; set; } = new();

        private static Collection _collection;
        private Collection() { }
        public static Collection GetGame() => _collection ??= _collection = new Collection();

    }
}
