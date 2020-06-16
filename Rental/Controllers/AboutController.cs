using Rental.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rental.Controllers
{
    public class AboutController : Controller
    {
        Classes.About onNewAbout = new Classes.About();
        // GET: About
        public ActionResult Show_About()
        {
            DataSet ds = onNewAbout.Show_About();
            ViewBag.oAbout = ds.Tables[0];
            return View();
        }
        public ActionResult Add_About()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add_About(FormCollection fc)
        {
            About oAbout = new About();
            oAbout.ATitle = fc["ATitle"];
            oAbout.ABody = fc["ABody"];
            oAbout.Date = DateTime.Now;
            onNewAbout.Add_About(oAbout);
            TempData["msg"] = "Insert Successfull";
            return RedirectToAction("Show_About");
            
        }
        public ActionResult Update_About(int id)
        {
            DataSet ds = onNewAbout.Show_About_ById(id);
            ViewBag.AboutRecord = ds.Tables[0];
            return View();
        }
        [HttpPost]
        public ActionResult Update_About(int id,FormCollection fc)
        {
            About oAbout = new About();
            oAbout.AboutId=id;
            oAbout.ATitle = fc["ATitle"];
            oAbout.ABody = fc["ABody"];
            onNewAbout.Update_About(oAbout);
            TempData["msg"] = "Update Successfull";
            return RedirectToAction("Show_About");

        }
        public ActionResult Delete_About(int id)
        {
            onNewAbout.Delete_About(id);
            TempData["msg"] = "Delete Successfull";

            return RedirectToAction("Show_About");
        }
    }

}