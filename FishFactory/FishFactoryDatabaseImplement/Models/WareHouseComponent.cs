using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace FishFactoryDatabaseImplement.Models
{
    public class WareHouseComponent
    {
        public int Id { get; set; }
        public int WareHouseId { get; set; }
        public int ComponentId { get; set; }
        [Required]
        public int Count { get; set; }
        public virtual Component Component { get; set; }
        public virtual WareHouse WareHouse { get; set; }
    }
}
