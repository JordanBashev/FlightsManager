﻿using FlightManager.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FlightManager.Services;

namespace FlightManager.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFlightService flightService;

        public HomeController(IFlightService flightService)
        {
            this.flightService = flightService;
        }

        public IActionResult Index()
        {
            var flights = this.flightService.GetAllFlights();
            return View(flights);
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
