using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Linq;
using Seawars.DAL.Context;
using Seawars.Domain.Entities;

namespace Seawars.Console
{

    class Connection
    {
        private static IHost _Hosting;

        public static IHost Hosting => _Hosting ??= CreateHostBuilder(Environment.GetCommandLineArgs()).Build();

        public static IServiceProvider Services = Hosting.Services;

        private static IHostBuilder CreateHostBuilder(string[] args) => Host
            .CreateDefaultBuilder(args)
            .ConfigureServices(ConfigureServices);

        private static void ConfigureServices(HostBuilderContext host, IServiceCollection services)
        {

            services.AddDbContext<DataBaseContext>(x =>
                x.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Seawars;Trusted_Connection=True", o =>
                    o.MigrationsAssembly("Seawars.DAL.SqlServer")));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var context = Connection.Hosting.Services.GetRequiredService<DataBaseContext>();

            //var user = new User()
            //{
            //    UserName = "Anton",
            //    Password = "0601",

            //};

            //context.Users.Add(user);
            //context.Games.Add(new Game()
            //{
            //    User = user,
            //    Steps = new List<Step>()
            //    {
            //        new Step()
            //        {
            //            X = 4,
            //            Y = 5
            //        }
            //    }
            //});

            //context.SaveChanges();

            //var user = context.Users.FirstOrDefault(x => x.Id == 1);
            //var game = context.Games.Include(x => x.Steps).FirstOrDefault(x => x.Id == user.Id);
            //var steps = context.Steps.FirstOrDefault(x => x.Id == 1);
            //context.Steps.Remove(steps);
            //context.Games.Remove(game);
            //context.Users.Remove(user);
            //context.SaveChanges();

        }
    }
}
