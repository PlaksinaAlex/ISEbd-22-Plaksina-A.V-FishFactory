using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishFactoryContracts.Enums;

namespace FishFactoryContracts.ViewModels
{
	public class ReportOrdersViewModel
	{
		public DateTime DateCreate { get; set; }

		public string CannedName { get; set; }

		public int Count { get; set; }

		public decimal Sum { get; set; }

		public OrderStatus Status { get; set; }
	}
}
