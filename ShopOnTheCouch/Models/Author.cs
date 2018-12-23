using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopOnTheCouch.Models
{
    public class Author
    {
        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonIgnore]
        public string Address { get; set; }
        [JsonIgnore]
        public string Email { get; set; }
        [JsonIgnore]
        public string Phone { get; set; }
        [JsonIgnore]
        public short Rating { get; set; }
        [JsonIgnore]
        public int Id { get; set; }
        [JsonIgnore]
        public virtual ICollection<Book> Books { get; set; }
        //многие к многим 
        public Author()
        {
            Books = new List<Book>();
        }


    }
}