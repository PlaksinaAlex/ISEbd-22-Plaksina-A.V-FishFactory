using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishFactoryContracts.BindingModels;
using FishFactoryContracts.StoragesContracts;
using FishFactoryContracts.ViewModels;
using FishFactoryListImplement.Models;

namespace FishFactoryListImplement.Implements
{
    public class OrderStorage : IOrderStorage
    {
        private readonly DataListSingleton source;
        public OrderStorage()
        {
            source = DataListSingleton.GetInstance();
        }

        public List<OrderViewModel> GetFullList()
        {
            List<OrderViewModel> result = new List<OrderViewModel>();
            foreach (var order in source.Orders)
            {
                result.Add(CreateModel(order));
            }
            return result;
        }
        public List<OrderViewModel> GetFilteredList(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            List<OrderViewModel> result = new List<OrderViewModel>();
            foreach (var order in source.Orders)
            {
                if ((!model.DateFrom.HasValue && !model.DateTo.HasValue && order.DateCreate == model.DateCreate) ||
                    (model.DateFrom.HasValue && model.DateTo.HasValue && order.DateCreate.Date >= model.DateFrom.Value.Date && order.DateCreate.Date <= model.DateTo.Value.Date) ||
                    (model.ClientId.HasValue && order.ClientId == model.ClientId) ||
                    (model.SearchStatus.HasValue && model.SearchStatus.Value == order.Status) ||
                    (model.ImplementerId.HasValue && order.ImplementerId == model.ImplementerId && model.Status == order.Status))
                {
                    result.Add(CreateModel(order));
                }
            }
            return result;
        }
        public OrderViewModel GetElement(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            foreach (var component in source.Orders)
            {
                if (component.Id == model.Id || component.CannedId == model.CannedId)
                {
                    return CreateModel(component);
                }
            }
            return null;
        }
        public void Insert(OrderBindingModel model)
        {
            Order tempOrder = new Order { Id = 1 };
            foreach (var order in source.Orders)
            {
                if (order.Id >= tempOrder.Id)
                {
                    tempOrder.Id = order.Id + 1;
                }
            }
            source.Orders.Add(CreateModel(model, tempOrder));
        }
        public void Update(OrderBindingModel model)
        {
            Order tempOrder = null;
            foreach (var order in source.Orders)
            {
                if (order.Id == model.Id)
                {
                    tempOrder = order;
                }
            }
            if (tempOrder == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, tempOrder);
        }
        public void Delete(OrderBindingModel model)
        {
            for (int i = 0; i < source.Orders.Count; ++i)
            {
                if (source.Orders[i].Id == model.Id.Value)
                {
                    source.Orders.RemoveAt(i);
                    return;
                }
            }
            throw new Exception("Элемент не найден");
        }
        private Order CreateModel(OrderBindingModel model, Order order)
        {
            order.ClientId = (int)model.ClientId;
            order.CannedId = model.CannedId;
            order.ImplementerId = model.ImplementerId;
            order.Count = model.Count;
            order.Sum = model.Sum;
            order.Status = model.Status;
            order.DateImplement = model.DateImplement;
            order.DateCreate = model.DateCreate;
            return order;
        }
        private OrderViewModel CreateModel(Order order)
        {
            string cannedName = "";
            foreach (var canned in source.Canneds)
            {
                if (canned.Id == order.CannedId)
                {
                    cannedName = canned.CannedName;
                    break;
                }
            }
            string clientFIO = null;
            foreach (Client client in source.Clients)
            {
                if (order.ClientId == client.Id)
                {
                    clientFIO = client.ClientFIO;
                    break;
                }
            }
            string implementerFIO = null;
            foreach (var implementer in source.Implementers)
            {
                if (implementer.Id == order.ImplementerId)
                {
                    implementerFIO = implementer.ImplementerFIO;
                    break;
                }
            }
            return new OrderViewModel
            {
                Id = order.Id,
                CannedId = order.CannedId,
                ClientId = order.ClientId,
                ClientFIO = clientFIO,
                ImplementerId = order.ImplementerId,
                ImplementerFIO = implementerFIO,
                Sum = order.Sum,
                Count = order.Count,
                Status = order.Status,
                CannedName = cannedName,
                DateCreate = order.DateCreate,
                DateImplement = order.DateImplement
            };
        }
    }
}
