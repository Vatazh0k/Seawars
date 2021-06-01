using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Seawars.Domain.Entities;

namespace Seawars.DAL.Context
{
    public class DataBaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Games> Games { get; set; }
        public DbSet<Steps> Steps { get; set; }
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);

            model.Entity<User>()
                .HasMany<Games>()
                .WithOne(x => x.Steps)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
