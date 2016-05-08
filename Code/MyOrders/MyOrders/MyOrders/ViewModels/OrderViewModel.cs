using GalaSoft.MvvmLight.Command;
using MyOrders.Models;
using MyOrders.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyOrders.ViewModels
{
    public class OrderViewModel
    {
        ApiService apiService;
        DialogService dialogService;

        public OrderViewModel()
        {
            apiService = new ApiService();
            dialogService = new DialogService();
            DeliveryDate = DateTime.Today;
        }

        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string DeliveryInformation { get; set; }
        public string Client { get; set; }
        public string Phone { get; set; }
        public bool IsDelivered { get; set; }
        public DateTime MinimumDate { get; private set; }

        public ICommand SaveCommand
        {
            get { return new RelayCommand(Save); }
        }


        private async void Save()
        {
            try
            {
                await apiService.CreateOrder(new Order()
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = this.Title,
                    Client = this.Client,
                    DeliveryDate = this.DeliveryDate,
                    DeliveryInformation = this.DeliveryInformation,
                    Description = this.Description,
                    IsDelivered = false
                });

                await dialogService.ShowMessage("El pedido ha sido creado.", "Información");
            }
            catch 
	        {
                await dialogService.ShowMessage("Ha ocuarrido un error inesperado.", "Error");
            }
        }
    }
}
