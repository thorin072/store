using Newtonsoft.Json;
using ShopOnTheCouch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopOnTheCouch.Controllers
{
    public class BookController : Controller
    {
        public ActionResult Index()
        {
            StoreContext db = new StoreContext();
            return View(db.Books.ToList());
        }

        [HttpPost]
        public ActionResult AddBook(Book book, string[] authFullName)
        {
            StoreContext db = new StoreContext();
            var newId = db.Books.OrderByDescending(x => x.Id).FirstOrDefault();
            Book newbook = new Book { Id = newId.Id+1, Title = book.Title, NumPages = book.NumPages, NumStock = book.NumStock };
            if (authFullName != null)
            {
                foreach (var newAuth in db.Authors.Where(i => authFullName.Contains(i.FullName)))
                {
                    newbook.Author.Add(newAuth);
                }
            }
            db.Books.Add(newbook);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult AddBook()
        {
            return View();
        }
        public ActionResult Edit(int id=0)
        {
            StoreContext db = new StoreContext();
            Book book = db.Books.Find(id);
            if (book == null) return HttpNotFound();
  
            ViewBag.AuthorsList = JsonConvert.SerializeObject(db.Authors);
      

            return View(book);
        }
        [HttpPost]
        public ActionResult Edit(Book book, string[] authFullName)
        {
            StoreContext db = new StoreContext();
            Book newbook = db.Books.Find(book.Id);
            newbook.Title = book.Title;
            newbook.NumStock = book.NumStock;
            newbook.NumPages = book.NumPages;
            newbook.Author.Clear();
            
            if (authFullName != null)
            {
                foreach (var newAuth in db.Authors.Where(i => authFullName.Contains(i.FullName)))
               {
                    newbook.Author.Add(newAuth);
               }
            }
            db.Entry(newbook).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}