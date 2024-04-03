using DigitalPolitechnicMobile.Views;
using DigitalPolitechnicMobile.ViewModels;
using DigitalPolitechnicMobile.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism;
using Prism.Navigation;
using Prism.Ioc;
using System.IO;
using System.Collections.Generic;

namespace DigitalPolitechnicMobile
{
    public partial class App
    {
        public App(IPlatformInitializer initilizer = null) : base(initilizer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync(nameof(HomePage));
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();

            containerRegistry.RegisterForNavigation<LogInPage, LogInViewModel>();            

            containerRegistry.RegisterForNavigation<HomePage, HomeViewModel>();
            containerRegistry.RegisterForNavigation<MapPage, MapViewModel>();
            containerRegistry.RegisterForNavigation<ProfilePage, ProfileViewModel>();
            containerRegistry.RegisterForNavigation<PhonesPage, PhonesViewModel>();
            containerRegistry.RegisterForNavigation<MenuPage,  MenuViewModel>();

            containerRegistry.RegisterForNavigation<AnnouncementPage, AnnouncementViewModel>();


        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

    }
}
