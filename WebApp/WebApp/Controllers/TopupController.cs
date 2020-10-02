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
    public class TopupController : Controller
    {
        private readonly ILogger<TopupController> _logger;
        public TopupController(ILogger<TopupController> logger)
        {
            _logger = logger;
        }

        [NoDirectAccess]
        public async Task<IActionResult> TopupBerasAwal(int id)
        {
            DeviceDetector.SetVersionTruncation(VersionTruncation.VERSION_TRUNCATION_NONE);
            BotParser botParser = new BotParser();
            var userAgent = Request.Headers["User-Agent"];
            var result = DeviceDetector.GetInfoFromUserAgent(userAgent);
            ViewBag.Device = result.Match.DeviceType.ToString();
            var model = new HomeModel();
            if (ViewBag.Device != "")
            {
                return await Task.Run(() => View(model));
            }
            else
            {
                return await Task.Run(() => View(model));
            }
        }
    }
}
