using System;
using System.Configuration;
using System.Linq;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Seawars.DAL.Context;
using Seawars.WPF.View.Windows;
using Seawars.WPF.ViewModels;
using Seawars.DAL.SqlServer.Repositories;
using Seawars.WPF.Services;
using Seawars.Domain.Entities;

namespace Seawars.WPF
{
    public partial class App : Application
    {
        public static User User;
        public static Window WindowActive => Current.Windows.Cast<Window>().FirstOrDefault(w => w.IsActive);
        public static Window WindowFocused => Current.Windows.Cast<Window>().FirstOrDefault(w => w.IsFocused);
        public static Window WindowCurrent => WindowFocused ?? WindowActive;

        private static IHost _Hosting;

        public static IHost Hosting => _Hosting ??= CreateHostBuilder(Environment.GetCommandLineArgs()).Build();

        public static IServiceProvider Services = Hosting.Services;

        private static IHostBuilder CreateHostBuilder(string[] args) => Host
            .CreateDefaultBuilder(args)
            .ConfigureServices(ConfigureServices);


       private static readonly string MsSqlConnectionString = ConfigurationManager.ConnectionStrings["MsSqlConnectionString"].ConnectionString;

        private static void ConfigureServices(HostBuilderContext host, IServiceCollection services)
        {
            services.AddScoped<AuthorizationPageViewModel>();
            services.AddScoped<UserPageViewModel>();

            services.AddSingleton<PageService>();

            services.AddScoped<UserRepository>();
            services.AddScoped<GameRepository>();
            services.AddScoped<StepRepository>();   

            services.AddDbContext<DataBaseContext>(x =>
                x.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Seawars;Trusted_Connection=True", o =>
                    o.MigrationsAssembly("Seawars.DAL.SqlServer")));
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            var host = Hosting;
            base.OnStartup(e);
            await host.StartAsync().ConfigureAwait(true);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            using var host = Hosting;
            base.OnExit(e);
            await host.StopAsync().ConfigureAwait(false); 
        }
    }
}
