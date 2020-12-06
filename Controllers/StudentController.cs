using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppAssesment.Models;

namespace WebAppAssesment.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Display()
        {
            List<Student> slist = new List<Student>()
            {
                new Student{SId=1,SName="Tanvi",SDOB=new DateTime(day:01,month:09,year:2006),SContact="787896844"},
                new Student{SId=2,SName="Mohan",SDOB=new DateTime(day:15,month:02,year:2007),SContact="7414412732"},
                new Student{SId=3,SName="Sam",SDOB=new DateTime(day:01,month:04,year:2012),SContact="9858745147"},
                new Student{SId=4,SName="Yashvi",SDOB=new DateTime(day:23,month:07,year:2014),SContact="9696857568"},
                new Student{SId=5,SName="Ajay",SDOB=new DateTime(day:12,month:08,year:2011),SContact="7896968123"},
            };
            int c = slist.Count();
            ViewBag.Total = c;
            return View(slist);
            
        }
    }
}