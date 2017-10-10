using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Myadata.Models;
namespace Myadata.Controllers
{
    public class HomeController : Controller
    {
     
        // GET: Home
       
        public ActionResult Index()
        {
            return View();
        }


        //public ActionResult ALL()
        //{

        //  //var x=  a.Tbl_info.ToList();
        //  //  return PartialView("_my",x);
        
        //}


        //public ActionResult TOP2()
        //{

        //    var x = a.Tbl_info.OrderBy(c => c.Name).Take(1).ToList();
        //    return PartialView("_my", x);
        
        //}
    }
}