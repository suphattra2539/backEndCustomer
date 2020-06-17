using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stuent.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        private Student model;
        private StudentView view;

        public StudentController(Student model, StudentView view)
        {
            this.model = model;
            this.view = view;
        }

        public void setStudentName(String name)
        {
            model.setName(name);
        }

        public String getStudentName()
        {
            return model.getName();
        }

        public void setStudentRollNo(String rollNo)
        {
            model.setRollNo(rollNo);
        }

        public String getStudentRollNo()
        {
            return model.getRollNo();
        }

        public void updateView()
        {
            view.printStudentDetails(model.getName(), model.getRollNo());
        }
    }
}