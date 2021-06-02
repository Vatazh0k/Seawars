using Seawars.WPF.Common;
using Seawars.WPF.View.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Seawars.WPF.Services
{
    public class PageService : ViewModelBase
    {
        private Page _CurrentPage;
        public Page CurrentPage
        {
            get => _CurrentPage;
            set => Set(ref _CurrentPage, value);
        }
        public PageService() => CurrentPage = new AuthorizationPage();
        public void SetPage<T>(T page) where T : Page => CurrentPage = page as Page;
    }
}
