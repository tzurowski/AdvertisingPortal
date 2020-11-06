using AdvertisingPortal.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdvertisingPortal.Models
{
    public class Advertisement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdvertisementId { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public string ImageUrl { get; set; }
        public string Discription { get; set; }
        public Car Car { get; set; }
        public AdvertisingPortalUser User { get; set; }
    }
}
