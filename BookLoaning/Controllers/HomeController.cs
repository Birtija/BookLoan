using BookEntity;
using BookEntity.Model;
using BookEntity.Repository;
using BookEntity.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookLoaning.Controllers
{
    public class HomeController : Controller
    {
        private BookLoanStatusService _context;

        public HomeController()
        {

        }
        public HomeController(BookLoanStatusService context)
        {
            _context = context;
        }
        
        public ActionResult Index()
        {
            var status = new BookLoanStatus() { Status="dd"};
             _context.InsertStatus(status);
            return View();
          
        }
       
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}