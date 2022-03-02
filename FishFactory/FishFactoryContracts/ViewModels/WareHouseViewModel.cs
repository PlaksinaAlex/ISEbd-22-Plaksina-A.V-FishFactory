using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace FishFactoryContracts.ViewModels
{
    public class WareHouseViewModel
    {
        public int Id { get; set; }
        [DisplayName("Название склада")]
        public string WareHouseName { get; set; }
        [DisplayName("Ответственное лицо")]
        public string ResponsibleFace { get; set; }
        [DisplayName("Дата создания")]
        public DateTime DateCreate { get; set; }

        public Dictionary<int, (string, int)> WareHouseComponents { get; set; }
    }
}
