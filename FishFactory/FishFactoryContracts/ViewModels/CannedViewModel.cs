using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace FishFactoryContracts.ViewModels
{
	public class CannedViewModel
	{
		public int Id { get; set; }
		[DisplayName("Название консерв")]
		public string CannedName { get; set; }
		[DisplayName("Цена")]
		public decimal Price { get; set; }
		public Dictionary<int, (string, int)> CannedComponents { get; set; }
	}
}
