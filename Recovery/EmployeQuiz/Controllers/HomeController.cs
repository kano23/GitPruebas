using EmployeQuiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace EmployeQuiz.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        //controller las peticiones del browse

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Employe emp)
        {
            //creo el objeto
            //del modelo de datos
            PayrollDm nomina = new PayrollDm(
                @"C:\Users\kano\documents\visual studio 2012\Projects\Recovery\EmployeQuiz\Models\base.csv");
            
            //busco el empleado dado su Id
            var empleado = nomina.GuetEmployeeById(emp.Id);

            if (ModelState.IsValid)
            {
                return View("WorkerView", empleado);
            }
            else
            {
                return View();
            }

           
        }

    }
}
