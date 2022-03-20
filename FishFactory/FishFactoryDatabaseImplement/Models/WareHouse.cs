using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FishFactoryDatabaseImplement.Models
{
    public class WareHouse
    {
        public int Id { get; set; }
        [Required]
        public string WareHouseName { get; set; }
        [Required]
        public string ResponsibleFace { get; set; }
        [Required]
        public DateTime DateCreate { get; set; }
        [ForeignKey("WareHouseId")]
        public List<WareHouseComponent> WareHouseComponents { get; set; }
    }
}
