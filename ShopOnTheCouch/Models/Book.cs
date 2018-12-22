using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopOnTheCouch.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Author> Author { get; set; }
        public short NumPages { get; set; }
        public short NumStock { get; set; }
        public virtual ICollection<CheckoutHistory> CheckoutHistories { get; set; }
        //многие к многим по отношению к Check 
        // один к многим по отношению Auth
        public Book()
        {
            Author = new List<Author>();
            CheckoutHistories = new List<CheckoutHistory>();
        }
      
    }
}