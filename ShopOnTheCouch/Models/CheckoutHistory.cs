using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;


namespace ShopOnTheCouch.Models
{
    public class CheckoutHistory
    {
        public int Id { get; set; }
        public DateTime CheckoutDate { get; set; }
        public DateTime CheckoutDateStock { get; set; }
        //один к многим
        public int? BookId { get; set; }
        public int? ClientId { get; set; }
        public Client Client { get; set; }
        public Book Book { get; set; }
    }
}