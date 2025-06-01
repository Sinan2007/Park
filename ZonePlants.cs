using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Park.Data.Data.Models
{
    public class ZonePlants
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Zones")]
        public int ZoneID { get; set; }
        public Zones Zones { get; set; }
        [ForeignKey("PlantSpecies")]
        public int PlantID { get; set; }
        public PlantSpecies PlantSpecies { get; set; }
        [Required]
        public string Density { get; set; }
    }
}
