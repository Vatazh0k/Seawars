using Seawars.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seawars.DAL.SqlServer.Repositories
{
    public class Repository
    {
        private readonly DataBaseContext _context;
        public Repository(DataBaseContext context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
