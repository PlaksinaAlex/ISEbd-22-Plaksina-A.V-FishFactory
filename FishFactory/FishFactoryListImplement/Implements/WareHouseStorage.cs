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
    public class WareHouseStorage : IWareHouseStorage
    {
        private readonly DataListSingleton source;
        public WareHouseStorage()
        {
            source = DataListSingleton.GetInstance();
        }
        public List<WareHouseViewModel> GetFullList()
        {
            List<WareHouseViewModel> result = new List<WareHouseViewModel>();
            foreach (var component in source.WareHouses)
            {
                result.Add(CreateModel(component));
            }
            return result;
        }
        public List<WareHouseViewModel> GetFilteredList(WareHouseBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            List<WareHouseViewModel> result = new List<WareHouseViewModel>();
            foreach (var warehouse in source.WareHouses)
            {
                if (warehouse.WareHouseName.Contains(model.WareHouseName))
                {
                    result.Add(CreateModel(warehouse));
                }
            }
            return result;
        }
        public WareHouseViewModel GetElement(WareHouseBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            foreach (var warehouse in source.WareHouses)
            {
                if (warehouse.Id == model.Id || warehouse.WareHouseName == model.WareHouseName)
                {
                    return CreateModel(warehouse);
                }
            }
            return null;
        }
        public void Insert(WareHouseBindingModel model)
        {
            WareHouse tempWareHouse = new WareHouse { Id = 1, WareHouseComponents = new Dictionary<int, int>() };
            foreach (var warehouse in source.WareHouses)
            {
                if (warehouse.Id >= tempWareHouse.Id)
                {
                    tempWareHouse.Id = warehouse.Id + 1;
                }
            }
            source.WareHouses.Add(CreateModel(model, tempWareHouse));
        }
        public void Update(WareHouseBindingModel model)
        {
            WareHouse tempWareHouse = null;
            foreach (var warehouse in source.WareHouses)
            {
                if (warehouse.Id == model.Id)
                {
                    tempWareHouse = warehouse;
                }
            }
            if (tempWareHouse == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, tempWareHouse);
        }
        public void Delete(WareHouseBindingModel model)
        {
            for (int i = 0; i < source.WareHouses.Count; ++i)
            {
                if (source.WareHouses[i].Id == model.Id)
                {
                    source.WareHouses.RemoveAt(i);
                    return;
                }
            }
            throw new Exception("Элемент не найден");
        }
        private WareHouse CreateModel(WareHouseBindingModel model, WareHouse warehouse)
        {
            warehouse.WareHouseName = model.WareHouseName;
            warehouse.ResponsibleFace = model.ResponsibleFace;
            warehouse.DateCreate = model.DateCreate;
            // удаляем убранные
            foreach (var key in warehouse.WareHouseComponents.Keys.ToList())
            {
                if (!model.WareHouseComponents.ContainsKey(key))
                {
                    warehouse.WareHouseComponents.Remove(key);
                }
            }
            // обновляем существуюущие и добавляем новые
            foreach (var component in model.WareHouseComponents)
            {
                if (warehouse.WareHouseComponents.ContainsKey(component.Key))
                {
                    warehouse.WareHouseComponents[component.Key] = model.WareHouseComponents[component.Key].Item2;
                }
                else
                {
                    warehouse.WareHouseComponents.Add(component.Key, model.WareHouseComponents[component.Key].Item2);
                }
            }
            return warehouse;
        }
        private WareHouseViewModel CreateModel(WareHouse warehouse)
        {
            // требуется дополнительно получить список компонентов для изделия с названиями и их количество
            Dictionary<int, (string, int)> warehouseComponents = new Dictionary<int, (string, int)>();
            foreach (var wh in warehouse.WareHouseComponents)
            {
                string componentName = string.Empty;
                foreach (var component in source.Components)
                {
                    if (wh.Key == component.Id)
                    {
                        componentName = component.ComponentName;
                        break;
                    }
                }
                warehouseComponents.Add(wh.Key, (componentName, wh.Value));
            }
            return new WareHouseViewModel
            {
                Id = warehouse.Id,
                WareHouseName = warehouse.WareHouseName,
                ResponsibleFace = warehouse.ResponsibleFace,
                DateCreate = warehouse.DateCreate,
                WareHouseComponents = warehouseComponents
            };
        }
        public bool WriteOffFromWarehouses(Dictionary<int, (string, int)> components, int writeOffCount)
        {
            return false;
        }

    }
}
