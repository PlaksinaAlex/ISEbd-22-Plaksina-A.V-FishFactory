using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using FishFactoryContracts.Enums;
using FishFactoryContracts.Attributes;

namespace FishFactoryContracts.ViewModels
{
	public class OrderViewModel
	{
		[Column(title: "Номер", width: 50)]
		public int Id { get; set; }
		public int ClientId { get; set; }
		public int? ImplementerId { get; set; }
		public int CannedId { get; set; }

		[Column(title: "Клиент", width: 70)]
		public string ClientFIO { get; set; }

		[Column(title: "Исполнитель", width: 100)]
		public string ImplementerFIO { get; set; }

		[Column(title: "Консервы", gridViewAutoSize: GridViewAutoSize.Fill)]
		public string CannedName { get; set; }

		[Column(title: "Количество", width: 80)]
		public int Count { get; set; }

		[Column(title: "Сумма", width: 60)]
		public decimal Sum { get; set; }

		[Column(title: "Статус", width: 100)]
		public OrderStatus Status { get; set; }

		[Column(title: "Дата создания", width: 110)]
		public DateTime DateCreate { get; set; }

		[Column(title: "Дата выполнения", width: 110)]
		public DateTime? DateImplement { get; set; }

	}
}
