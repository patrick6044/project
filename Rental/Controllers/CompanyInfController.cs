
using Rental.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rental.Controllers
{
    public class CompanyInfController : Controller
    {
        Classes.Company oCompany = new Classes.Company();
        // GET: CompanyInf
     
        public ActionResult ViewCompany()
        {
            DataSet ds = oCompany.ViewCompany();
            ViewBag.onNewCompany = ds.Tables[0];
            return View();
        }
        public ActionResult Add_Company()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add_Company(FormCollection fc)
        {
            Company_model onNewCompany = new Company_model();
            onNewCompany.CompanyName = fc["CompanyName"];
            onNewCompany.Phone = fc["Phone"];
            onNewCompany.Email = fc["Email"];
            onNewCompany.Facebook = fc["FaceBook"];
            onNewCompany.Twitter = fc["Twitter"];
            onNewCompany.Whatsapp = fc["Whatsapp"];
            onNewCompany.Location = fc["Location"];
            oCompany.Add_Company(onNewCompany);
            TempData["msg"] = "Insert Successful";
            return View();

          
        }
        public ActionResult Delete_Company(int id)
        {
            oCompany.Delete_Company(id);
            TempData["msg"] = "Delete Successful";
            return RedirectToAction("ViewCompany");

        }
        public ActionResult Update_Company(int id)
        {
            DataSet ds = oCompany.ViewCompany_ById(id);
            ViewBag.CompanyRecord = ds.Tables[0];
            return View();
        }
        [HttpPost]
        public ActionResult Update_Company(int id,FormCollection fc)
        {
            Company_model onNewCompany = new Company_model();
            onNewCompany.CompanyId=id;
            onNewCompany.CompanyName = fc["CompanyName"];
            onNewCompany.Phone = fc["Phone"];
            onNewCompany.Email = fc["Email"];
            onNewCompany.Facebook = fc["FaceBook"];
            onNewCompany.Twitter = fc["Twitter"];
            onNewCompany.Whatsapp = fc["Whatsapp"];
            onNewCompany.Location = fc["Location"];
            oCompany.Update_Company(onNewCompany);
            TempData["msg"] = "Update Successful";
            return RedirectToAction("ViewCompany");


        }
    }
}