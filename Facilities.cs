using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Park.Data.Data.Models
{
    public class Facilities
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Zones")]
        public int ZoneID { get; set; }
        public Zones Zones { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Material { get; set; }
        [Required]
        public string Condition { get; set; }
        public DateTime InstalledOn { get; set; }

    }
}
