using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using FishFactoryContracts.Attributes;

namespace FishFactoryContracts.ViewModels
{
	public class CannedViewModel
	{
		public int Id { get; set; }

		[Column(title: "Название консерв", gridViewAutoSize: GridViewAutoSize.Fill)]
		public string CannedName { get; set; }
		[Column(title: "Цена", width: 100)]
		public decimal Price { get; set; }
		public Dictionary<int, (string, int)> CannedComponents { get; set; }
	}
}
