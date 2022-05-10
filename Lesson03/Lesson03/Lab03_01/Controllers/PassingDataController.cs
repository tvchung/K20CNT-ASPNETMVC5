using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab03_01.Controllers
{
    public class PassingDataController : Controller
    {
        // GET: PassingData
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VewDataTest()
        {
            ViewData["message1"] = "ViewData chỉ tồn tại trong một Request và giá trị trở về null khi chuyển hướng(Redirect)";
            ViewData["message2"] = "ViewData yêu cầu chuyển kiểu dữ liệu và kiểm ta null để tránh lỗi";
            string[] students = { "Hạnh", "Tuyên", "Thủy", "Tiến" };
            ViewData["student"] = students;
            return View();
        }

        public ActionResult VewBagTest()
        {
            // ViewBag là biến trung gian dùng để truyền dữ liệu từ cont
            ViewBag.message1 = "ViewBag chỉ tồn tại trong một Request và giá trị trở về null khi chuyển hướng(Redirect)";
            ViewBag.message2 = "ViewBag yêu cầu chuyển kiểu dữ liệu và kiểm ta  null để tránh lỗi";
            string[] students = { "Hạnh", "Tuyên", "Thủy", "Tiến" };
            ViewBag.students = students;
            return View();
        }
    }
}