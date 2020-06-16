using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rental.Controllers
{
    public class DashboardController : Controller
    {
        Classes.Comment oComment = new Classes.Comment();
        // GET: Dashboard
        public ActionResult Index()
        {
            DataSet ds = oComment.Dashboard();
            ViewBag.onNewComment = ds.Tables[0];
            return View();
           
        }
    }
}