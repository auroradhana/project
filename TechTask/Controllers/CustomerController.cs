using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechTask.Models;

namespace TechTask.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetData()
        {
            using (DBModel db = new DBModel())
            {
                List<CustomerDB> empList = db.CustomerDBs.ToList<CustomerDB>();
                return Json(new { data = empList }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}