using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Park.Data.Data.Models
{
    public class Zones
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public int Area_HA { get; set; }
        public List<Facilities> ListOfFacilities { get; set; } = new List<Facilities>();
        public List<ZonePlants> ListOfZonePlant { get; set; } = new List<ZonePlants>();
    }
}
