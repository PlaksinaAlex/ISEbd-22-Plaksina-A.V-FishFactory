using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using FishFactoryContracts.Enums;

namespace FishFactoryContracts.ViewModels
{
	public class OrderViewModel
	{
		public int Id { get; set; }

		public int ClientId { get; set; }
		public int? ImplementerId { get; set; }
		public int CannedId { get; set; }

		[DisplayName("Клиент")]
		public string ClientFIO { get; set; }

		[DisplayName("Исполнитель")]
		public string ImplementerFIO { get; set; }

		[DisplayName("Консервы")]
		public string CannedName { get; set; }
		[DisplayName("Количество")]
		public int Count { get; set; }
		[DisplayName("Сумма")]
		public decimal Sum { get; set; }
		[DisplayName("Статус")]
		public OrderStatus Status { get; set; }
		[DisplayName("Дата создания")]
		public DateTime DateCreate { get; set; }
		[DisplayName("Дата выполнения")]
		public DateTime? DateImplement { get; set; }

	}
}
