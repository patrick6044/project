using Rental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rental.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Autherize(Rental.Models.tblUser userModels)
        {
            using (RentalDBEntities db=new RentalDBEntities())
            {
                var userDetails = db.tblUsers.Where(x => x.UserName == userModels.UserName && x.Password == userModels.Password).FirstOrDefault();
                if (userDetails == null)
                {
                    userModels.LoginerrorMessage = "Wrong Credential";
                    return View("Index",userModels);
                }
                else
                {
                    Session["UserId"] = userDetails.UserId;
                    Session["Fname"] = userDetails.Fname;
                    Session["Lname"] = userDetails.Lname;
                    Session["Email"] = userDetails.Email;

                    return RedirectToAction("Index", "Dashboard");
                }

            }
           
        }
        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}