using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seawars.Interfaces.Entities;

namespace Seawars.Interfaces.Repositories
{
    public interface IRepository<T> where T : IEntity
    {
        List<T> GetAllUser();
        T GetById(int id);
        void Add();
        void Update();
        void Delete();
        void DeleteById(int id);
        bool ExistId(int id);

    }
}
