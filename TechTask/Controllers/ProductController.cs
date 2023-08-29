using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechTask.Models;

namespace TechTask.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetData()
        {
            using (DBModel db = new DBModel())
            {
                List<ProductDB> empList = db.ProductDBs.ToList<ProductDB>();
                return Json(new { data = empList }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}