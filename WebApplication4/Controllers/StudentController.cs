using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            Student aStudent = new Student();
            aStudent.Age = 25;
            aStudent.StudentId = 4586;
            aStudent.StudentName = "abdul";
            Department aDepartment = new Department();
            aDepartment.DepartmentName = "CSE";
            aDepartment.Departmentid = 1256;
            aDepartment.AllStudents.Add(aStudent);

            StudentDeparmt aDeparmt =   new StudentDeparmt();
            aDeparmt.Student = aStudent;
            aDeparmt.Department = aDepartment;
            return View(aDeparmt);
        }
    }
}