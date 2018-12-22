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

        public ActionResult AddBook()
        {
            return View();

        }
        public ActionResult Edit(int id=0)
        {
            StoreContext db = new StoreContext();
            Book book = db.Books.Find(id);
            if (book == null) return HttpNotFound();
            ViewBag.AuthorsList = db.Authors.ToList();
            return View(book);
        }
        //[HttpPost]
        //public ActionResult Edit(Book book,string[] authFullName)
        //{
        //    StoreContext db = new StoreContext();
        //    Book newbook = db.Books.Find(book.Id);
        //    newbook.Title = book.Title;
        //    newbook.NumStock = book.NumStock;
        //    newbook.NumPages = book.NumPages;
        //    newbook.Author.Clear();
        //    if (authFullName!=null)
        //    {
        //        foreach (var newAuth in db.)
        //        {
        //            newbook.Author.Add(newAuth);
        //        }
        //    }
        //    return RedirectToAction("Index");
        //}

    }
}