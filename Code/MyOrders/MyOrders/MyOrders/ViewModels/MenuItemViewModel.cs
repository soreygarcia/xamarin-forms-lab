using GalaSoft.MvvmLight.Command;
using MyOrders.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyOrders.ViewModels
{
    public class MenuItemViewModel
    {
        public string Icon { get; set; }
        public string Title { get; set; }
        public string PageName { get; set; }

        public ICommand NavigateCommand
        {
            get { return new RelayCommand(Navigate); }
        }

        private void Navigate()
        {
            App.Master.IsPresented = false;
            switch (PageName)
            {
                case "AlarmsPage":
                    App.Navigator.PushAsync(new AlarmsPage());
                    break;
                case "ClientsPage":
                    App.Navigator.PushAsync(new ClientsPage());
                    break;
                case "SettingsPage":
                    App.Navigator.PushAsync(new SettingsPage());
                    break;
                case "MainPage":
                    App.Navigator.PopToRootAsync();
                    App.Navigator.PushAsync(new MainPage());
                    break;
                default:
                    break;
            }
        }
    }
}
