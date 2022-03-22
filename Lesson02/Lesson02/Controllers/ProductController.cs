using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson02.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            // code logic cho action index [ /productt/index ]
            string[] Names = { "Hùng", "Dũng", "Sang", "Trọng" };
            ViewBag.Data = Names;

            return View();
        }

        // Tạo action ProductDetail
        public ActionResult ProductDetail(string id)
        {
            // Code logi

            ViewBag.Data = id;

            return View();
        }

        // Kiểu trả về string
        public string GetName()
        {
            return "Đây là sản phẩm Iphone XS 15";
        }

        public JsonResult GetNames()
        {
            string[] Names = { "Hùng", "Dũng", "Sang", "Trọng" };
            return Json(Names, JsonRequestBehavior.AllowGet);
        }
    }
}