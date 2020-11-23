using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvertisingPortal.ModelView
{
    public class AdvertisementMV
    {
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public float FuelTank { get; set; }
        public string FuelType { get; set; }
        public string Description { get; set; }
    }
}
