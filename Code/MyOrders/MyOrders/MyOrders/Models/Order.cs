using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOrders.Models
{
    public class Order
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("Title")]
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string DeliveryInformation { get; set; }
        public string Client { get; set; }
        public string Phone { get; set; }
        public bool? IsDelivered { get; set; }
    }
}
