using Sol_Demo.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Sol_Demo.ViewModels
{
    public class Page2ViewModel
    {
        private INavigation navigation = null;

        public Page2ViewModel()
        {
            NavigatePage3 = new Command(async () => await this.NavigatePage3Async());
            NavigateMainPage = new Command(async () => await this.NavigateMainPageAsync());
        }

        public ICommand NavigatePage3 { get; set; }

        public ICommand NavigateMainPage { get; set; }

        private async Task NavigatePage3Async()
        {
            navigation = Application.Current.MainPage.Navigation;
            await navigation.PushAsync(new Page3());
        }

        private async Task NavigateMainPageAsync()
        {
            navigation = Application.Current.MainPage.Navigation;
            await navigation.PushAsync(new MainPage());
        }
    }
}