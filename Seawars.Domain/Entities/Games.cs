using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seawars.Interfaces.Entities;

namespace Seawars.Domain.Entities
{
    public class Games : IEntity
    {
        public int Id { get; }

        public User Steps { get; set; }
    }
}
