using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishFactoryListImplement.Models
{
	public class WareHouse
	{
		public int Id { get; set; }
		public string WareHouseName { get; set; }
		public string ResponsibleFace { get; set; }
		public DateTime DateCreate { get; set; }
		public Dictionary<int, int> WareHouseComponents { get; set; }
	}
}
