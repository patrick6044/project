using Rental.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rental.Controllers
{
    public class MasterheadController : Controller
    {
        Classes.Masterhead oMaster = new Classes.Masterhead();
        // GET: Masterhead
        public ActionResult Add_Masterhead()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add_Masterhead(FormCollection fc)
        {
            MasterHead_model onNewMaster = new MasterHead_model();
            onNewMaster.Head = fc["Head"];
            onNewMaster.Body = fc["Body"];
            onNewMaster.Date = DateTime.Now;
            oMaster.Add_Masterhead(onNewMaster);
            TempData["msg"] = "Insert Successfull";
            return RedirectToAction("Show_Masterhead");
        }
        public ActionResult Show_Masterhead()
        {
            DataSet ds = oMaster.Show_Masterhead();
            ViewBag.onNewMaster = ds.Tables[0];
            return View();

        }
        public ActionResult Update_MasterHead(int id)
        {
            DataSet ds = oMaster.Show_Masterhead_ById(id);
            ViewBag.MasterRecord= ds.Tables[0];
            return View();
        }
        [HttpPost]
        public ActionResult Update_MasterHead(int id,FormCollection fc)
        {
            MasterHead_model onNewMaster = new MasterHead_model();
            onNewMaster.MasterheadId = id;
            onNewMaster.Head = fc["Head"];
            onNewMaster.Body = fc["Body"];
           
            oMaster.Update_MasterHead(onNewMaster);
            TempData["msg"] = "Update Successfull";
            return RedirectToAction("Show_Masterhead");
        }

        public ActionResult Delete_Masthead( int id)
        {
            oMaster.Delete_Masthead(id);
            TempData["msg"] = "Delete Successfull";
            return RedirectToAction("Show_Masterhead");
        }


    }
}