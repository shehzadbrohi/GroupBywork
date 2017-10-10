using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Myadata.Models;
namespace Myadata.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Login()
        {

            ViewBag.mess = "Hi have you done it";
            return PartialView("_my");
        
        }


        public ActionResult data()
        {

            List<Abc> a = new List<Abc>();
            a.Add(new Abc { id = 1, Name = "Karachi", salary= 10000 });
            a.Add(new Abc { id = 2, Name = "Karachi",salary= 5000 });
            a.Add(new Abc { id = 3, Name = "Lahore",salary= 6000 });
            a.Add(new Abc { id = 4, Name = "Karachi",salary= 70000 });
            a.Add(new Abc { id = 5, Name = "lahore",salary= 50000 });

            var x = a.GroupBy(b => b.Name);
            return View(x);
        }
    }
}