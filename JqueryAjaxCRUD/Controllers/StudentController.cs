using JqueryAjaxCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JqueryAjaxCRUD.Controllers
{
    public class StudentController : Controller
    {
        private SchoolDbContext db;

        public StudentController()
        {
            db = new SchoolDbContext();
        }
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult LoadData()
        {
            bool status = false;
            List<Student> listStudent=null;
            try
            {
                listStudent = (from s in db.Students select s).ToList();
                status = true;
            }
            catch
            {

            }

            return Json(new {
                data = listStudent,
                status = status
            },JsonRequestBehavior.AllowGet);
        }
    }
}