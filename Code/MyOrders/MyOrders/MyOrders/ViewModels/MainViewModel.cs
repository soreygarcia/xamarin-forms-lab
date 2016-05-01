using GalaSoft.MvvmLight.Command;
using MyOrders.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyOrders.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            LoadMenu();
            LoadData();
        }

        #region Properties
        public ObservableCollection<OrderViewModel> Orders { get; set; }

        public ObservableCollection<MenuItemViewModel> Menu { get; set; }
        #endregion

        #region Commands
        public ICommand GoToCommand
        {
            get { return new RelayCommand<string>(GoTo); }
        }

        private void GoTo(string pageName)
        {
            switch (pageName)
            {
                case "NewOrderPage":
                    App.Navigator.PushAsync(new NewOrderPage());
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region Methods
        private void LoadMenu()
        {
            Menu = new ObservableCollection<MenuItemViewModel>();

            Menu.Add(new MenuItemViewModel()
            {
                Icon = "ic_action_orders",
                Title = "Pedidos",
                PageName = "MainPage"
            });

            Menu.Add(new MenuItemViewModel()
            {
                Icon = "ic_action_clients",
                Title = "Clientes",
                PageName = "ClientsPage"
            });

            Menu.Add(new MenuItemViewModel()
            {
                Icon = "ic_action_alarm",
                Title = "Alarmas",
                PageName = "AlarmsPage"
            });

            Menu.Add(new MenuItemViewModel()
            {
                Icon = "ic_action_settings",
                Title = "Ajustes",
                PageName = "SettingsPage"
            });
        }

        private void LoadData()
        {
            Orders = new ObservableCollection<OrderViewModel>();
            for (int i = 0; i < 5; i++)
            {
                Orders.Add(new OrderViewModel()
                {
                    Title = "Lorem Ipsum",
                    DeliveryDate = DateTime.Today,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                });
            }
        } 
        #endregion

    }
}
