using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai2_S3P1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            TempData["Name"] = "Nguyễn Văn A";
            TempData["Age"] = "18";
            TempData["Address"] = "Hà Nội";
            return Redirect("Student/ShowData");
        }

        public ActionResult ShowData()
        {
            return View("ShowData");
        }
    }
}