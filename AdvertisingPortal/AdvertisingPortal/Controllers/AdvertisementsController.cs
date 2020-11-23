using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvertisingPortal.Data;
using AdvertisingPortal.ModelView;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public IActionResult Index(string search, int? i)
        {
            var ads = _db.Advertisements.Include(c => c.Car).Where(x => x.Title.Contains(search) || search == null)
                .Select(x => new AdvertisementMV {
                    ImageUrl = x.ImageUrl,
                    Title = x.Title,
                    Price = x.Price,
                    Make = x.Car.Make,
                    Model = x.Car.Model,
                    Year = x.Car.Year,
                    FuelTank = x.Car.FuelTank,
                    FuelType = x.Car.FuelType,
                    Description = x.Description
                }).ToList().ToPagedList(i ?? 1, 6);
            return View(ads);
        }
    }
}
