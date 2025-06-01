using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Park.Data.Data.Models
{
    public class PlantSpecies
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LatinName { get; set; }
        [Required]
        public bool IsProtected { get; set; }
        [Required]
        public string Description { get; set; }
        public List<ZonePlants> ListOfZonePlants { get; set; } = new List<ZonePlants>();
    }
}
