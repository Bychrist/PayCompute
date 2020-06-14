using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PayCompute.Models;
using PayCompute.Services;

namespace PayCompute.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IActionResult    Index()
        {
            IEnumerable<EmployeeIndexViewModel> employees = (IEnumerable<EmployeeIndexViewModel>) _employeeService.GetAll();
            
            return View(employees);

        }


















    }




}
