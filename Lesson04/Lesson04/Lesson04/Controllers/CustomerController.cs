using Lesson04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson04.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        // Customer Detail
        public ActionResult CustomerDetail()
        {
            Customer cus = new Customer()
            {
                CustomerId = "C001",
                FirstName = "Nguyễn Thọ",
                LastName = "Cường",
                Address = "28A Lê Trọng Tấn",
                YearOfBirth = 2002
            };
            ViewBag.customer = cus;
            return View();
        }

        // List Customer
        public ActionResult ListCustomer()
        {
            List<Customer> list = new List<Customer>()
            {
                new Customer(){CustomerId="C001",FirstName = "Nguyễn Thọ",
                LastName = "Cường", Address = "28 A Lê trọng tấn",YearOfBirth = 2002},
                new Customer()
                {
                    CustomerId = "C002", FirstName="Đỗ Quang", LastName="Đưởng",
                    Address = "123 Abc", YearOfBirth=2002
                },
                new Customer()
                {
                    CustomerId="C003",
                    FirstName="Nguyễn Thị Phương", LastName="Ánh", Address="Thái bình",
                    YearOfBirth=2003
                },
                new Customer()
                {
                    CustomerId="C004",
                    FirstName="Cao Nguyễn", LastName="An", Address="Thái bình",
                    YearOfBirth=2003
                }
            };
            ViewBag.list = list;
            return View();
        }
    }
}