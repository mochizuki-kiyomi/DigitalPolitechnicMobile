using DigitalPolitechnicMobile.Services;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

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





    }
}
