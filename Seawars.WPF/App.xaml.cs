using System;
using System.Linq;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Seawars.WPF.View.Windows;
using Seawars.WPF.ViewModels;

namespace Seawars.WPF
{
    public partial class App : Application
    {
        public static Window WindowActive => Current.Windows.Cast<Window>().FirstOrDefault(w => w.IsActive);
        public static Window WindowFocused => Current.Windows.Cast<Window>().FirstOrDefault(w => w.IsFocused);
        public static Window WindowCurrent => WindowFocused ?? WindowActive;

        private static IHost _Hosting;

        public static IHost Hosting => _Hosting ??= CreateHostBuilder(Environment.GetCommandLineArgs()).Build();

        public static IServiceProvider Services = Hosting.Services;

        private static IHostBuilder CreateHostBuilder(string[] args) => Host
            .CreateDefaultBuilder(args)
            .ConfigureServices(ConfigureServices);

        private static void ConfigureServices(HostBuilderContext host, IServiceCollection services)
        {
            services.AddScoped<AuthorizationWindowViewModel>();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            var host = Hosting;
            base.OnStartup(e);
            await host.StartAsync().ConfigureAwait(true);
            //Services.GetRequiredService<AuthorizationWindow>().Show();
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            using var host = Hosting;
            base.OnExit(e);
            await host.StopAsync().ConfigureAwait(false); 
        }
    }
}
