using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rental.Models;

namespace Rental.Controllers
{
    public class WebsiteController : Controller
    {
        Classes.Comment oComment = new Classes.Comment();
        Classes.Website oWebsite = new Classes.Website();
      
        // GET: Website
        public ActionResult MyWebsite()
        {
            DataSet ds = oWebsite.ViewCompany();           
            ViewBag.onNewCompany = ds.Tables[0];
            return View();
           
        }
        [HttpPost]
        public ActionResult MyWebsite(FormCollection fc)
        {
            Comment_model onNewComment = new Comment_model();
            onNewComment.Name = fc["Name"];
            onNewComment.Email = fc["Email"];
            onNewComment.Message = fc["Message"];
            onNewComment.Date = DateTime.Now;

            oComment.MyWebsite(onNewComment);
            TempData["msg"] = "Insert Successful";
            return View(); 

        }
       



    }
}