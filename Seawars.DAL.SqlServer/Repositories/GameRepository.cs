using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seawars.DAL.Context;
using Seawars.Domain.Entities;
using Seawars.Interfaces.Repositories;

namespace Seawars.DAL.SqlServer.Repositories
{
    public class GameRepository : IRepository<Game>
    {
        private readonly DataBaseContext _context;
        public GameRepository(DataBaseContext context)
        {
            _context = context;
        }
        
        public List<Game> GetAll()
        {
            return _context.Games.Select(x => x).ToList();
        }

        public Game GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Add<T>(T Game)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T entity)
        {
            if (entity is null) return;
            _context.Games.Remove(entity as Game);
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public bool ExistId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
