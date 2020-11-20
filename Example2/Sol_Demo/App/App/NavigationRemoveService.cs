using NavigationServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using App.Views;
using CircleImageDemo.Views;
using CardViewDemo.Views;

namespace App
{
    public class NavigationRemoveService : INavigationRemoveService
    {
        Task INavigationRemoveService.RemoveOthersPagesExceptAnimalViewPageNavigationStack()
        {
            return Task.Run(() =>
            {
                var existingPages = App.Current.MainPage.Navigation.NavigationStack.ToList();

                foreach (var page in existingPages)
                {
                    if (page.GetType() == typeof(AnimalViewPage))
                        continue;
                    App.Current.MainPage.Navigation.RemovePage(page);
                }
            });
        }

        Task INavigationRemoveService.RemoveOthersPagesExceptCardViewPageNavigationSatck()
        {
            return Task.Run(() =>
            {
                var existingPages = App.Current.MainPage.Navigation.NavigationStack.ToList();

                foreach (var page in existingPages)
                {
                    if (page.GetType() == typeof(CardViewPage))
                        continue;
                    App.Current.MainPage.Navigation.RemovePage(page);
                }
            });
        }

        Task INavigationRemoveService.RemoveOthersPagesExceptMainPageNavigationStack()
        {
            return Task.Run(() =>
            {
                var existingPages = App.Current.MainPage.Navigation.NavigationStack.ToList();

                foreach (var page in existingPages)
                {
                    if (page.GetType() == typeof(MainPage))
                        continue;
                    App.Current.MainPage.Navigation.RemovePage(page);
                }
            });
        }
    }
}