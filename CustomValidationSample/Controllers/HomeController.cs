using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//davamate
using CustomValidationSample.Models;

namespace CustomValidationSample.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Employee emp) {
            if (ModelState.IsValid) {
                ModelState.Clear();
                return View();
            }
            return View();
        }
    }
}