﻿using System;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using TruecaApp.Services;

namespace TruecaApp.ViewModels
{
    public class MenuItemViewModel
    {
        private NavigationService navigationService;

        public string Icon
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public string PageName
        {
            get;
            set;
        }

        public MenuItemViewModel()
        {
            navigationService = new NavigationService();
        }

        #region Commands
        public ICommand NavigateCommand
        {
            get
            {
                return new RelayCommand(Navigate);
            }
        }

        private async void Navigate()
        {
            await navigationService.Navigate(PageName);
        }

      
        #endregion
    }
}
