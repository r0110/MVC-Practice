using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcPractice.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public string Index(string id)
        {
            return $"My student id is: {id}";
        }
    }
}