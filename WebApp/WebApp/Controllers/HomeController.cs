using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApp.Models;
using DeviceDetectorNET;
using DeviceDetectorNET.Parser;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            DeviceDetector.SetVersionTruncation(VersionTruncation.VERSION_TRUNCATION_NONE);
            BotParser botParser = new BotParser();
            var userAgent = Request.Headers["User-Agent"];
            var result = DeviceDetector.GetInfoFromUserAgent(userAgent);
            ViewBag.Device = result.Match.DeviceType.ToString();
            var model = new HomeModel();
            if(ViewBag.Device == "smartphone")
            {
                return await Task.Run(() => View(model));
            }
            else
            {
                return await Task.Run(() => View(model));
            }
        }
        public async Task<IActionResult> HartaAwal()
        {
            DeviceDetector.SetVersionTruncation(VersionTruncation.VERSION_TRUNCATION_NONE);
            BotParser botParser = new BotParser();
            var userAgent = Request.Headers["User-Agent"];
            var result = DeviceDetector.GetInfoFromUserAgent(userAgent);
            ViewBag.Device = result.Match.DeviceType.ToString();
            var model = new HomeModel();
            if (ViewBag.Device == "smartphone")
            {
                return await Task.Run(() => View(model));
            }
            else
            {
                return await Task.Run(() => View(model));
            }
        }
        public async Task<IActionResult> Beranda()
        {
            DeviceDetector.SetVersionTruncation(VersionTruncation.VERSION_TRUNCATION_NONE);
            BotParser botParser = new BotParser();
            var userAgent = Request.Headers["User-Agent"];
            var result = DeviceDetector.GetInfoFromUserAgent(userAgent);
            ViewBag.Device = result.Match.DeviceType.ToString();
            var model = new HomeModel();
            if (ViewBag.Device == "smartphone")
            {
                return await Task.Run(() => View(model));
            }
            else
            {
                return await Task.Run(() => View(model));
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
