
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShopOnTheCouch.Models
{
    public class StoreContext : DbContext
    {
        //static StoreContext()
        //{
        //   Database.SetInitializer(new ShopDbInitializer());
        //}
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<CheckoutHistory> CheckoutHistories { get; set; }
    }
    class ShopDbInitializer : DropCreateDatabaseAlways<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
           
            Author auth1 = new Author { FullName = "Рихтер Джеффри", Rating = 10, Id = 1 };
            Author auth2 = new Author { FullName = "Шилдт Герберт", Rating = 6, Id = 2 };
            Author auth3 = new Author { FullName = "Борзунов Сергей Викторович", Rating = 9, Phone = "+7(981)674-6095", Id = 3 };
            Author auth4 = new Author { FullName = "Кургалин Сергей Дмитриевич", Rating = 7, Phone = "+7(980)899-1095", Id = 4 };

            context.Authors.Add(auth1);
            context.Authors.Add(auth2);
            context.Authors.Add(auth3);
            context.Authors.Add(auth4);

            Book b1 = new Book { Id = 2, Title = "Java. Руководство для начинающих", NumPages = 816, NumStock = 4, Author = new List<Author> { auth2 } };
            Book b2 = new Book { Id = 1, Title = "WinRT. программирование на C# для профессионалов", NumPages = 1205, NumStock = 1, Author = new List<Author> { auth1 } };
            Book b3 = new Book { Id = 3, Title = "Суперкомпьютерные вычисления: практический подход", NumPages = 256, NumStock = 5, Author = new List<Author> { auth3,auth4 } };

            context.Books.Add(b1);
            context.Books.Add(b2);
            context.Books.Add(b3);

            context.SaveChanges();
            base.Seed(context);
        }

    }
}