using Seawars.WPF.View.Windows;
using Seawars.WPF.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Seawars.DAL.Context;

namespace Seawars.WPF.Services
{
    internal class ServicesLocator
    {
        public static AuthorizationWindowViewModel AuthorizationWindowViewModel =>
            App.Services.GetRequiredService<AuthorizationWindowViewModel>();


        public static DataBaseContext DataBaseContext =>
            App.Services.GetRequiredService<DataBaseContext>();
    }
}
