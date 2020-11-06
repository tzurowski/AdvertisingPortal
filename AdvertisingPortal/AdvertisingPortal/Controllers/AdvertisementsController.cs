using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AdvertisingPortal.Controllers
{
    public class AdvertisementsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
