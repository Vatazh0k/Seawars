using Seawars.WPF.View.Windows;
using Seawars.WPF.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Seawars.DAL.Context;
using Seawars.DAL.SqlServer.Repositories;

namespace Seawars.WPF.Services
{
    internal class ServicesLocator
    {
        public static AuthorizationWindowViewModel AuthorizationWindowViewModel =>
            App.Services.GetRequiredService<AuthorizationWindowViewModel>();


        public static UserRepository UserRepository =>
            App.Services.GetRequiredService<UserRepository>();


        public static GameRepository GameRepository =>
            App.Services.GetRequiredService<GameRepository>();


        public static StepRepository StepRepository =>
            App.Services.GetRequiredService<StepRepository>();
    }
}
