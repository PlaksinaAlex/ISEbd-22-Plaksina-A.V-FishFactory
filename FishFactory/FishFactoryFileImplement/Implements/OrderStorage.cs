using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishFactoryContracts.BindingModels;
using FishFactoryContracts.StoragesContracts;
using FishFactoryContracts.ViewModels;
using FishFactoryFileImplement.Models;

namespace FishFactoryFileImplement.Implements
{
	public class OrderStorage : IOrderStorage
	{
		private readonly FileDataListSingleton source;
		public OrderStorage()
		{
			source = FileDataListSingleton.GetInstance();
		}
		public List<OrderViewModel> GetFullList()
		{
			return source.Orders.Select(CreateModel).ToList();
		}
		public List<OrderViewModel> GetFilteredList(OrderBindingModel model)
		{
			if (model == null)
			{
				return null;
			}
			return source.Orders.Where(rec => rec.CannedId.ToString().Contains(model.CannedId.ToString())).Select(CreateModel).ToList();
		}
		public OrderViewModel GetElement(OrderBindingModel model)
		{
			if (model == null)
			{
				return null;
			}
			var order = source.Orders.FirstOrDefault(rec => rec.CannedId == model.CannedId || rec.Id == model.Id);
			return order != null ? CreateModel(order) : null;
		}

		public void Insert(OrderBindingModel model)
		{
			int maxId = source.Orders.Count > 0 ? source.Orders.Max(rec => rec.Id) : 0;
			var element = new Order { Id = maxId + 1 };
			source.Orders.Add(CreateModel(model, element));
		}
		public void Update(OrderBindingModel model)
		{
			var element = source.Orders.FirstOrDefault(rec => rec.Id == model.Id);
			if (element == null)
			{
				throw new Exception("Заказ не найден");
			}
			CreateModel(model, element);
		}
		public void Delete(OrderBindingModel model)
		{
			Order element = source.Orders.FirstOrDefault(rec => rec.Id == model.Id);
			if (element != null)
			{
				source.Orders.Remove(element);
			}
			else
			{
				throw new Exception("Элемент не найден");
			}
		}
		private Order CreateModel(OrderBindingModel model, Order order)
		{
			order.CannedId = model.CannedId;
			order.Status = model.Status;
			order.Sum = model.Sum;
			order.DateCreate = model.DateCreate;
			order.DateImplement = model.DateImplement;
			order.Count = model.Count;
			return order;
		}
		private OrderViewModel CreateModel(Order order)
		{
			
			return new OrderViewModel
			{
				Id = order.Id,
				CannedId = order.CannedId,
				Status = order.Status,
				Sum = order.Sum,
				DateCreate = order.DateCreate,
				DateImplement = order.DateImplement,
				Count = order.Count,
				CannedName = source.Canneds.FirstOrDefault(canned=>canned.Id==order.CannedId)?.CannedName
			};
		}
	}
}
