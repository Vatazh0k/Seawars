using Seawars.WPF.View.Windows;
using Seawars.WPF.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Seawars.DAL.Context;
using Seawars.DAL.SqlServer.Repositories;
using Seawars.WPF.Services.AuthorizationPageServices;
using Seawars.WPF.Services.GamePagesService;

namespace Seawars.WPF.Services
{
    internal class ServicesLocator
    {
        public static UserFieldPageViewModel UserFieldPageViewModel =>
            App.Services.GetRequiredService<UserFieldPageViewModel>();


        public static ConnectionPageViewModel ConnectionPageViewModel =>
            App.Services.GetRequiredService<ConnectionPageViewModel>();


        public static AuthorizationPageViewModel AuthorizationWindowViewModel =>
            App.Services.GetRequiredService<AuthorizationPageViewModel>();


        public static UserPageViewModel UserPageViewModel =>
          App.Services.GetRequiredService<UserPageViewModel>();


        public static PageService PageService =>
           App.Services.GetRequiredService<PageService>();


        public static GamePageService GamePageService =>
            App.Services.GetRequiredService<GamePageService>();


        public static UserRepository UserRepository =>
            App.Services.GetRequiredService<UserRepository>();


        public static GameRepository GameRepository =>
            App.Services.GetRequiredService<GameRepository>();


        public static StepRepository StepRepository =>
            App.Services.GetRequiredService<StepRepository>();


        public static Repository Repository =>
          App.Services.GetRequiredService<Repository>();
    }
}
