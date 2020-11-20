using Sol_Demo.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Sol_Demo.ViewModels
{
    public class MainPageViewModel
    {
        private INavigation navigation = null;

        public MainPageViewModel()
        {
            NavigatePage2 = new Command(async () => await this.NavigatePage2Async());
        }

        public ICommand NavigatePage2 { get; set; }

        private async Task NavigatePage2Async()
        {
            navigation = Application.Current.MainPage.Navigation;
            await navigation.PushAsync(new Page2());
        }
    }
}