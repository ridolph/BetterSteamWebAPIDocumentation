﻿using SteamWebAPI2;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BetterSteamWebAPIDocumentation.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            string steamWebApiKey = ConfigurationManager.AppSettings["steamWebApiKey"].ToString();
            SteamWebSession session = new SteamWebSession(steamWebApiKey);
            var interfaces = await session.GetSupportedAPIListAsync();

            return View(interfaces);
        }
    }
}