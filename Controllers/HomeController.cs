﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using TJTest.Models;


namespace TJTest.Controllers
{
    public class HomeController : Controller
    {
        public bool RegisterNewClient(string clientName)
        {
            bool result = false;
            try
            {
                DbTJTest dbTJTest = new DbTJTest();
                result = dbTJTest.RegisterNewClient(clientName);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;

        }
        public bool  SearchClient(string clientName)
        {
            try
            {
                DbTJTest dbTJTest = new DbTJTest();
                return (dbTJTest.SearchClient(clientName));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}