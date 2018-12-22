using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopOnTheCouch.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Job { get; set; }
        public ICollection<CheckoutHistory> CheckoutHistories { get; set; }
        public Client()
        {
            CheckoutHistories = new List<CheckoutHistory>();

        }
    }
}