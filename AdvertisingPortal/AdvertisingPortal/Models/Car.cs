using AdvertisingPortal.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdvertisingPortal.Models
{
    public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CarId { get; set; }

        [Required]
        public string Make { get; set; }

        public string Model { get; set; }
        public DateTime Year { get; set; }

        [Required]
        public int Mileage { get; set; }

        public float FuelTank { get; set; }
        public string FuelType { get; set; }

    }
}
