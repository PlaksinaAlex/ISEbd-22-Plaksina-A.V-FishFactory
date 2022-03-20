using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishFactoryContracts.BindingModels;
using FishFactoryContracts.StoragesContracts;
using FishFactoryContracts.ViewModels;
using FishFactoryDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;

namespace FishFactoryDatabaseImplement.Implements
{
    public class OrderStorage : IOrderStorage
    {
        public List<OrderViewModel> GetFullList()
        {
            using (FishFactoryDatabase context = new FishFactoryDatabase())
            {
                return context.Orders.Include(rec => rec.Canned)
                .Select(rec => new OrderViewModel
                {
                    Id = rec.Id,
                    CannedId = rec.CannedId,
                    CannedName = rec.Canned.CannedName,
                    Count = rec.Count,
                    Sum = rec.Sum,
                    Status = rec.Status,
                    DateCreate = rec.DateCreate,
                    DateImplement = rec.DateImplement,
                })
                .ToList();
            }
        }
        public List<OrderViewModel> GetFilteredList(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (FishFactoryDatabase context = new FishFactoryDatabase())
            {
                return context.Orders.Include(rec => rec.Canned)
                .Where(rec => rec.CannedId == model.CannedId)
                .Select(rec => new OrderViewModel
                {
                    Id = rec.Id,
                    CannedId = rec.CannedId,
                    CannedName = rec.Canned.CannedName,
                    Count = rec.Count,
                    Sum = rec.Sum,
                    Status = rec.Status,
                    DateCreate = rec.DateCreate,
                    DateImplement = rec.DateImplement,
                })
                .ToList();
            }
        }
        public OrderViewModel GetElement(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (FishFactoryDatabase context = new FishFactoryDatabase())
            {
                Order order = context.Orders.Include(rec => rec.Canned)
                .FirstOrDefault(rec => rec.Id == model.Id);
                return order != null ?
                new OrderViewModel
                {
                    Id = order.Id,
                    CannedId = order.CannedId,
                    CannedName = order.Canned.CannedName,
                    Count = order.Count,
                    Sum = order.Sum,
                    Status = order.Status,
                    DateCreate = order.DateCreate,
                    DateImplement = order.DateImplement,
                } :
                null;
            }
        }
        public void Insert(OrderBindingModel model)
        {
            using (FishFactoryDatabase context = new FishFactoryDatabase())
            {
                Order order = new Order
                {
                    CannedId = model.CannedId,
                    Count = model.Count,
                    Sum = model.Sum,
                    Status = model.Status,
                    DateCreate = model.DateCreate,
                    DateImplement = model.DateImplement,
                };
                context.Orders.Add(order);
                context.SaveChanges();
                CreateModel(model, order);
                context.SaveChanges();
            }
        }
        public void Update(OrderBindingModel model)
        {
            using (FishFactoryDatabase context = new FishFactoryDatabase())
            {
                Order element = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Элемент не найден");
                }
                element.CannedId = model.CannedId;
                element.Count = model.Count;
                element.Sum = model.Sum;
                element.Status = model.Status;
                element.DateCreate = model.DateCreate;
                element.DateImplement = model.DateImplement;
                CreateModel(model, element);
                context.SaveChanges();
            }
        }
        public void Delete(OrderBindingModel model)
        {
            using (FishFactoryDatabase context = new FishFactoryDatabase())
            {
                Order element = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Orders.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }
        private Order CreateModel(OrderBindingModel model, Order order)
        {
            if (model == null)
            {
                return null;
            }

            using (FishFactoryDatabase context = new FishFactoryDatabase())
            {
                Canned element = context.Canneds.FirstOrDefault(rec => rec.Id == model.CannedId);
                if (element != null)
                {
                    if (element.Orders == null)
                    {
                        element.Orders = new List<Order>();
                    }
                    element.Orders.Add(order);
                    context.Canneds.Update(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
            return order;
        }
    }
}

