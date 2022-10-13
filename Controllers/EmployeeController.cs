using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeDetails.Models;


namespace EmployeeDetails.Controllers
    {
        public class EmployeeController : Controller
        {


            // GET: Employee
            public ActionResult Index()
            {
                return View();
            }
            public ActionResult EmployeeLoginpage()
            {
            return View();
        }
            public ActionResult EmployeeSuccesspage(Class1 user)
            {
            if (user.Employee_Name == "pavi" && user.Emp_password == 123 && user.Email_Id =="Pavi@gmail.com")
            {
                ViewBag.Empdetails = "successfuly updated";
                ViewData["Employee_Datas"] = "Employee Grade of September : Grade is A";
                TempData["tempresult"] = "Employee Grade August: Grade is A+";
                return RedirectToAction("EmployeeData");
            }
            else
            {
                ViewBag.Emplo = "Enter correct Employee_Name and Emp_password ";
            }
            return View();
                    }
        public ActionResult EmployeeData()
        {      
                List<Class1> ab = new List<Class1>();
                ab.Add(new Class1 { Employee_Name = "pavithra", Email_Id ="pavithra@gmail.com" , Emp_password = 145});
                ab.Add(new Class1 { Employee_Name = "dine", Email_Id= "dine@gmail.com", Emp_password = 146 });
                ab.Add(new Class1 { Employee_Name = "kumar", Email_Id = "kumar@gmail.com",Emp_password = 147 });
                ab.Add(new Class1 { Employee_Name = "dira", Email_Id="dira@gmail.com",Emp_password = 148 });
           
                return View(ab);
            }
        }
    }
    
