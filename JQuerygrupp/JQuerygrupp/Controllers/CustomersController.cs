﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JQuerygrupp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JQuerygrupp.Controllers
{
    public class CustomersController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(DataManager.GetCustomers());
        }

        public IActionResult _CustomerInfo(int id)
        {
            return View(DataManager.GetCustomerById(id));
        }

        public IActionResult GetAll()
        {
            return Json(DataManager.GetCustomers());
        }
    }
}
