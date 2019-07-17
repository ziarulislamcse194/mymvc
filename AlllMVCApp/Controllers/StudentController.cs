using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AlllMVCApp.Models.Models;
using AlllMVCApp.BLL.BLL;


namespace AlllMVCApp.Controllers
{
    public class StudentController : Controller
    {
        StudentManager _studentManager = new StudentManager();

        Student _student = new Student();

        // GET: Student
        public ActionResult Add()
        {
            _student.ID = 1;
            _student.Name = "Ziarul";
            _studentManager.Add(_student);

            return View();
        }
    }
}