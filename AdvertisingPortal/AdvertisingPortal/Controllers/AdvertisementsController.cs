using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvertisingPortal.Data;
using Microsoft.AspNetCore.Mvc;

namespace AdvertisingPortal.Controllers
{
    public class AdvertisementsController : Controller
    {
        private readonly AdvertisingPortalDbContext _db;
        public AdvertisementsController(AdvertisingPortalDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var ads = _db.Advertisements.Select(c => c).ToList();
            return View(ads);
        }
    }
}
