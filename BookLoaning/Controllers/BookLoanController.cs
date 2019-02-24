
using BookEntity.Service;
using BookLoaning.Models;
using BookEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookLoaning.Controllers
{
    public class BookLoanController : Controller
    {
        private PersonService _personContext;
        public BookLoanController(PersonService context)
        {
            _personContext = context;
        }
        // GET: BookLoan
        public ActionResult AddLoan()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddLoan(PersonDTO p)
        {
            var person = new User();
            person.LastName = p.LastName;
            person.Name = p.Name;
            _personContext.Insert(person);
            return View();
        }
    }
}