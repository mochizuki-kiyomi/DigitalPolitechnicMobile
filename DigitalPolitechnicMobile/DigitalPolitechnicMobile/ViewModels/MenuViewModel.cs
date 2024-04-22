using DigitalPolitechnicMobile.Views;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace DigitalPolitechnicMobile.ViewModels
{
    internal class MenuViewModel : ViewModelBase
    {
        public MenuViewModel(INavigationService navigationService) : base(navigationService)
        {
        }


        private ICommand home;
        public ICommand Home
        {
            get => home ??= new DelegateCommand(async () => await NavigationService.NavigateAsync(nameof(HomePage)));
        }

        private ICommand map;
        public ICommand Map
        {
            get => map ??= new DelegateCommand(async () => await NavigationService.NavigateAsync(nameof(MapPage)));
        }

        private ICommand profile;
        public ICommand Profile
        {
            get => profile ??= new DelegateCommand(async () => await NavigationService.NavigateAsync(nameof(ProfilePage)));
        }

        private ICommand phones;
        public ICommand Phones
        {
            get => phones ??= new DelegateCommand(async () => await NavigationService.NavigateAsync(nameof(PhonesPage)));
        }

        private ICommand menu;
        public ICommand Menu
        {
            get => menu ??= new DelegateCommand(async () => await NavigationService.NavigateAsync(nameof(MenuPage)));
        }
    }
}
