using System;
using System.Collections.Generic;
using System.Text;
using Prism.Commands;
using Prism.Navigation;

namespace DigitalPolitechnicMobile.ViewModels
{
    class AnnouncementViewModel : ViewModelBase
    {
        public AnnouncementViewModel(INavigationService navigationService) : base(navigationService)
        {
        }


        private string name;
        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        private string text;
        public string Text
        {
            get { return text; }
            set { SetProperty(ref text, value); }
        }

    }
}
