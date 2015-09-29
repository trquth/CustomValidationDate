using CustomValidationDate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomValidationDate.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(RegisterValidationViewModel newEmployee)
        {
            if (ModelState.IsValid)
            {
                //insert code here
            }
            return View();
        }
    }
}