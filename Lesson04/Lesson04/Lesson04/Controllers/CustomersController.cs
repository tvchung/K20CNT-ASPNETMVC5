using Lesson04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson04.Controllers
{
    public class CustomersController : Controller
    {
        static List<Customer> list = new List<Customer>()
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

        // GET: Customers
        public ActionResult Index()
        {
            return View(list);
        }

        // GET: Customers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        [HttpPost]
        public ActionResult Create(Customer cus)
        {
            try
            {
                // TODO: Add insert logic here
                list.Add(cus);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(string id)
        {
            return View();
        }

        // POST: Customers/Edit/5
        [HttpPost]
        public ActionResult Edit(Customer   customer)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customers/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
