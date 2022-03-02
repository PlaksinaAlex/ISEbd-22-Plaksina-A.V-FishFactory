using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishFactoryContracts.BindingModels
{
	public class WareHouseRestockingBindingModel
	{
		public int WareHouseId { get; set; }

		public int ComponentId { get; set; }

		public int Count { get; set; }
	}
}
