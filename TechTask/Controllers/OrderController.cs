using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechTask.Models;

namespace TechTask.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetData()
        {
            using (DBModel db = new DBModel())
            {
                List<OrderDB> empList = db.OrderDBs.ToList<OrderDB>();
                return Json(new { data = empList }, JsonRequestBehavior.AllowGet);
            }
        }

       
    }
}