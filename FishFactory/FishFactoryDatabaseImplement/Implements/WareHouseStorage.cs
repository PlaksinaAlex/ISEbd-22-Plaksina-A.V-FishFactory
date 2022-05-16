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
    public class WareHouseStorage : IWareHouseStorage
    {
        public List<WareHouseViewModel> GetFullList()
        {
            using var context = new FishFactoryDatabase();
            return context.WareHouses
                .Include(rec => rec.WareHouseComponents)
                .ThenInclude(rec => rec.Component)
                .ToList()
                .Select(CreateModel)
                .ToList();
        }
        public List<WareHouseViewModel> GetFilteredList(WareHouseBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new FishFactoryDatabase();
            return context.WareHouses
            .Include(rec => rec.WareHouseComponents)
            .ThenInclude(rec => rec.Component)
            .Where(rec => rec.WareHouseName.Contains(model.WareHouseName))
            .ToList()
            .Select(CreateModel)
            .ToList();
        }
        public WareHouseViewModel GetElement(WareHouseBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new FishFactoryDatabase();
            var warehouse = context.WareHouses
            .Include(rec => rec.WareHouseComponents)
            .ThenInclude(rec => rec.Component)
            .FirstOrDefault(rec => rec.WareHouseName.Equals(model.WareHouseName) || rec.Id == model.Id);
            return warehouse != null ? CreateModel(warehouse) : null;
        }
        public void Insert(WareHouseBindingModel model)
        {
            using var context = new FishFactoryDatabase();
            using var transaction = context.Database.BeginTransaction();
            try
            {
                WareHouse warehouse = new WareHouse()
                {
                    WareHouseName = model.WareHouseName,
                    ResponsibleFace = model.ResponsibleFace,
                    DateCreate = model.DateCreate
                };
                context.WareHouses.Add(warehouse);
                context.SaveChanges();
                CreateModel(model, warehouse, context);
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
        public void Update(WareHouseBindingModel model)
        {
            using var context = new FishFactoryDatabase();
            using var transaction = context.Database.BeginTransaction();
            try
            {
                var element = context.WareHouses.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Элемент не найден");
                }
                CreateModel(model, element, context);
                context.SaveChanges();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
        public void Delete(WareHouseBindingModel model)
        {
            using var context = new FishFactoryDatabase();
            WareHouse element = context.WareHouses.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.WareHouses.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
        private static WareHouse CreateModel(WareHouseBindingModel model, WareHouse warehouse, FishFactoryDatabase context)
        {
            warehouse.WareHouseName = model.WareHouseName;
            warehouse.ResponsibleFace = model.ResponsibleFace;
            warehouse.DateCreate = model.DateCreate;
            if (model.Id.HasValue)
            {
                var warehouseComponents = context.WareHouseComponents.Where(rec =>
                rec.WareHouseId == model.Id.Value).ToList();
                // удалили те, которых нет в модели
                context.WareHouseComponents.RemoveRange(warehouseComponents.Where(rec =>
                !model.WareHouseComponents.ContainsKey(rec.ComponentId)).ToList());
                context.SaveChanges();
                // обновили количество у существующих записей
                foreach (var updateComponent in warehouseComponents)
                {
                    updateComponent.Count =
                    model.WareHouseComponents[updateComponent.ComponentId].Item2;
                    model.WareHouseComponents.Remove(updateComponent.ComponentId);
                }
                context.SaveChanges();
            }
            // добавили новые
            foreach (var wc in model.WareHouseComponents)
            {
                context.WareHouseComponents.Add(new WareHouseComponent
                {
                    WareHouseId = warehouse.Id,
                    ComponentId = wc.Key,
                    Count = wc.Value.Item2,
                });
                try
                {
                    context.SaveChanges();
                }
                catch
                {
                    throw;
                }
            }
            return warehouse;
        }
        private static WareHouseViewModel CreateModel(WareHouse warehouse)
        {
            return new WareHouseViewModel
            {
                Id = warehouse.Id,
                WareHouseName = warehouse.WareHouseName,
                ResponsibleFace = warehouse.ResponsibleFace,
                DateCreate = warehouse.DateCreate,
                WareHouseComponents = warehouse.WareHouseComponents
            .ToDictionary(recWC => recWC.ComponentId,
            recWC => (recWC.Component?.ComponentName, recWC.Count))
            };
        }
        public bool WriteOffFromWarehouses(Dictionary<int, (string, int)> components, int writeOffCount)
        {
            using (var context = new FishFactoryDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        foreach (KeyValuePair<int, (string, int)> component in components)
                        {
                            int count = component.Value.Item2 * writeOffCount;
                            IEnumerable<WareHouseComponent> warehouseComponents = context.WareHouseComponents
                                .Where(warehouse => warehouse.ComponentId == component.Key);
                            if (warehouseComponents.Sum(warehouseComponent => warehouseComponent.Count) < count)
                            {
                                throw new Exception("Недостаточно комнонентов");
                            }
                            foreach (WareHouseComponent warehouseComponent in warehouseComponents)
                            {
                                if (warehouseComponent.Count <= count)
                                {
                                    count -= warehouseComponent.Count;
                                    context.WareHouseComponents.Remove(warehouseComponent);
                                }
                                else
                                {
                                    warehouseComponent.Count -= count;
                                    count = 0;
                                }
                                if (count == 0)
                                {
                                    break;
                                }
                            }

                        }
                        context.SaveChanges();
                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }
    }
}
