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
            _student.Name = "Sultan";
            _studentManager.Add(_student);

            return View();
        }

        public ActionResult Delete()
        {
            _student.ID = 2;
            _studentManager.Delete(_student);

            return View();
        }

        public ActionResult Update()
        {
            _student.ID = 5;
            _student.Name = "Rahim";
            _studentManager.Update(_student);

            return View();
        }

        public ActionResult GetByID()
        {
            _student.ID = 5;
            Student bStudent = _studentManager.GetByID(_student);

            return View();
        }

        public ActionResult GetAll()
        {
            _student.ID = 5;
            List<Student> bStudent = _studentManager.GetAll(_student);

            return View();
        }
    }
}