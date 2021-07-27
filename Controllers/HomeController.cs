using DotNetCoreConfiguration.Models;
using DotNetCoreConfiguration.SettingModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreConfiguration.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly MySettings _mySettings;

        public HomeController(IConfiguration configuration, IOptions<MySettings> options)
        {
            _configuration = configuration;
            _mySettings = options.Value;
        }

        public IActionResult Index()
        {
            string volume = _configuration["MySettings:Volume"];
            string moveUpKey = _configuration["MySettings:InputMapping:Up"];

            bool isMute = _mySettings.IsMute;
            string moveDownKey = _mySettings.InputMapping.Down;

            var model = new MySettingsViewModel()
            {
                Volume = _mySettings.Volume,
                IsMute = _mySettings.IsMute,
                Display = _mySettings.Display,
                InputMapping = _mySettings.InputMapping
            };

            return View(model);
        }
    }
}
