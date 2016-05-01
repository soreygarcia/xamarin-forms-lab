using MyOrders.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOrders.Infrastructure
{
    public class InstanceLocator
    {
        public InstanceLocator()
        {
            Main = new MainViewModel();
        }

        public MainViewModel Main { get; set; }
    }
}
