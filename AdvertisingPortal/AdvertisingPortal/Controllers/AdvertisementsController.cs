﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvertisingPortal.Data;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;
using X.PagedList.Mvc.Core;

namespace AdvertisingPortal.Controllers
{
    public class AdvertisementsController : Controller
    {
        private readonly AdvertisingPortalDbContext _db;
        public AdvertisementsController(AdvertisingPortalDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(int? i)
        {
            var ads = _db.Advertisements.Select(c => c).ToList().ToPagedList(i ?? 1, 2);
            return View(ads);
        }
    }
}
