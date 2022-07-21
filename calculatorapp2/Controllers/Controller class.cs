using Addition.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Addition.Controllers
{
    public class HomeController : Controller
    {
        //    
        // GET: /Home/    
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(AdditionViewModel model, string command)
        {
            if (command == "add")
            {
                model.Result = model.A + model.B;
            }
            if (command == "sub")
            {
                model.Result = model.A - model.B;
            }
            if (command == "mul")
            {
                model.Result = model.A * model.B;
            }
            if (command == "div")
            {
                model.Result = model.A / model.B;
            }
            if (command == "sqrt")
            {
                model.Result = model.A * model.A;
            }
            if (command == "sqthrd")
            {
                model.Result = model.A * model.A * model.A;
            }
            if (command == "percent")
            {
                model.Result = ((model.B / model.A)* 100);
                
            }
            if (command == "sin")
            {
                model.Result = Math.Sin(model.A);
            }
            if (command == "cos")
            {
                model.Result = Math.Cos(model.A);
            }
            if (command == "tan")
            {
                model.Result = Math.Tan(model.A);
            }
            return View(model);
        }
    }
}