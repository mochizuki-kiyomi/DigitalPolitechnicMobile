using DigitalPolitechnicMobile.Services;
using DigitalPolitechnicMobile.Views;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace DigitalPolitechnicMobile.ViewModels
{
    class HomeViewModel : ViewModelBase
    {
        public HomeViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        private List<ImportantAnnounce> importantAnnounces;
        public List<ImportantAnnounce> ImportanteAnnounce
        {
            get => importantAnnounces;
            set => SetProperty(ref importantAnnounces, value);
        }

        private List<News> news;
        public List<News> News
        {
            get => news;
            set => SetProperty(ref news, value);
        }

        private System.Collections.IEnumerable importantAnnounce;

        public System.Collections.IEnumerable ImportantAnnounce 
        { 
            get => importantAnnounce; set => SetProperty(ref importantAnnounce, value); }



        private ICommand map;
        public ICommand Map
        {
            get => map ??= new DelegateCommand(async () => await NavigationService.NavigateAsync(nameof(MapPage)));
        }

    }
}
