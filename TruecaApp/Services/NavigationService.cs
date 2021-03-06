﻿using System.Threading.Tasks;
using TruecaApp.Pages;

namespace TruecaApp.Services
{
    public class NavigationService
    {
        public async Task SetMainPage(string pageName)
        {
            switch(pageName)
            {
                case "MasterPage":
                    App.Current.MainPage = new MasterPage();
                    break;
                case "LoginPage":
                    App.Current.MainPage = new LoginPage();
                    break;
                case "LoginFacebookPage":
                    App.Current.MainPage = new LoginFacebookPage();
                    break;
                default:
                break;
            }
        }

        public async Task Navigate(string pageName)
        {
            switch(pageName)
            {
                case "MasterPage":
                    await App.Current.MainPage.Navigation.PushAsync(new MasterPage());
                    break;
                case "AboutPage":
                    await App.Current.MainPage.Navigation.PushAsync(new AboutPage());
                    break;
                case "LoginPage":
                    await App.Current.MainPage.Navigation.PushAsync(new LoginPage());
                    break;
                case "LoginFacebookPage":
                    await App.Current.MainPage.Navigation.PushAsync(new LoginFacebookPage());
                    break;
                default:
                    break;
            }
        }

        public async Task Back()
        {
            await App.Current.MainPage.Navigation.PopAsync();
        }
    }
}
