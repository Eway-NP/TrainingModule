using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WKFramework.Models;

namespace WKFramework.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
       

        [HttpGet]
        public ActionResult Index1()
        {
            var userlist = new List<UserInfo>
            {
                new UserInfo() {Name = "AA", Age = 11, Email = "AA@163.com", Password = "AA123"},
                new UserInfo() {Name = "CC", Age = 11, Email = "CC@163.com", Password = "AA123"},
                new UserInfo() {Name = "bb", Age = 11, Email = "bb@163.com", Password = "AA123"},
                new UserInfo() {Name = "Dd", Age = 11, Email = "Dd@163.com", Password = "AA123"}
            };
            return View(userlist);
        }
        [NonAction]      
        [HttpGet]
        public ActionResult Index2()
        {
            return Json("");
        }
    }
}