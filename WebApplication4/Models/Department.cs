﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace WebApplication4.Models
{
    public class Department
    {
        public int Departmentid { get; set; }
        public string DepartmentName { get; set; }
        public List<Student> AllStudents = new List<Student>();
    }
}