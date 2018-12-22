using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopOnTheCouch.Models
{
    public class Author
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public short Rating { get; set; }
        public int Id { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        //многие к многим 
        public Author()
        {
            Books = new List<Book>();
        }


    }
}