using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson03.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {

            ViewData["msg"] = "Thông báo, bây giờ là:";
            ViewData["Time"] = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy tt");
            return View();
        }

        public ActionResult StudentList()
        {
            string[] names = { "Nguyễn Thanh Hằng", "Nguyễn Thọ Cường", "Cao Giang Linh", "Đỗ Văn Tưởng" };
            ViewBag.names = names;
            ViewBag.msg = "Danh sách lớp K20CNT-FITNTU";
            return View();
        }
    }
}