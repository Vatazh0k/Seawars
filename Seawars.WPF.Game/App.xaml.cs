using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Seawars.DAL.Context;
using Seawars.DAL.SqlServer.Repositories;
using Seawars.WPF.Game.View.Windows;

namespace Seawars.WPF.Game
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static IHost _Hosting;

        public static IHost Hosting => _Hosting ??= CreateHostBuilder(Environment.GetCommandLineArgs()).Build();

        private static IHostBuilder CreateHostBuilder(string[] args) => Host
            .CreateDefaultBuilder(args)
            .ConfigureServices(ConfigureServices);


        private static void ConfigureServices(HostBuilderContext host, IServiceCollection services)
        {
           

            services.AddScoped<Repository>();

            services.AddScoped<UserRepository>();
            services.AddScoped<GameRepository>();
            services.AddScoped<StepRepository>();

           
        }

        public static void Start()
        {
            new GameWindow().ShowDialog();
            var users = App.Hosting.Services.GetRequiredService<UserRepository>();
            var a =users.GetAll();
        }

       
    }
}
