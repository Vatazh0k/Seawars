using Seawars.WPF.View.Windows;
using Seawars.WPF.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace Seawars.WPF.Services
{
    internal class ServicesLocator
    {
        public AuthorizationWindowViewModel AuthorizationWindowViewModel =>
            App.Services.GetRequiredService<AuthorizationWindowViewModel>();
    }
}
