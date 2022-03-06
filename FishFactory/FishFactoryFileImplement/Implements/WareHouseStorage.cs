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
    public class WareHouseStorage : IWareHouseStorage
    {
        private readonly FileDataListSingleton source;
        public WareHouseStorage()
        {
            source = FileDataListSingleton.GetInstance();
        }
        public List<WareHouseViewModel> GetFullList()
        {
            return source.WareHouses.Select(CreateModel).ToList();
        }
        public List<WareHouseViewModel> GetFilteredList(WareHouseBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            return source.WareHouses.Where(rec => rec.WareHouseName.ToString().Contains(model.WareHouseName.ToString())).Select(CreateModel).ToList();
        }
        public WareHouseViewModel GetElement(WareHouseBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            var warehouse = source.WareHouses.FirstOrDefault(rec => rec.WareHouseName == model.WareHouseName || rec.Id == model.Id);
            return warehouse != null ? CreateModel(warehouse) : null;
        }
        public void Insert(WareHouseBindingModel model)
        {
            int maxId = source.WareHouses.Count > 0 ? source.WareHouses.Max(rec => rec.Id) : 0;
            var element = new WareHouse
            {
                Id = maxId + 1,
                WareHouseComponents = new Dictionary<int, int>(),
                DateCreate = DateTime.Now
            };
            source.WareHouses.Add(CreateModel(model, element));
        }
        public void Update(WareHouseBindingModel model)
        {
            var element = source.WareHouses.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, element);
        }
        public void Delete(WareHouseBindingModel model)
        {
            WareHouse element = source.WareHouses.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                source.WareHouses.Remove(element);
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
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

            return new WareHouseViewModel
            {
                Id = warehouse.Id,
                WareHouseName = warehouse.WareHouseName,
                ResponsibleFace = warehouse.ResponsibleFace,
                DateCreate = warehouse.DateCreate,
                WareHouseComponents = warehouse.WareHouseComponents.ToDictionary(recPC => recPC.Key, recPC =>
                        (source.Components.FirstOrDefault(recC => recC.Id == recPC.Key)?.ComponentName, recPC.Value))
            };
        }
        public bool WriteOffFromWarehouses(Dictionary<int, (string, int)> components, int writeOffCount)
        {
            foreach (var component in components)
            {
                int count = source.WareHouses.Where(comp => comp.WareHouseComponents.ContainsKey(component.Key)).Sum(comp => comp.WareHouseComponents[component.Key]);

                if (count < component.Value.Item2 * writeOffCount)
                {
                    return false;
                }
            }
            foreach (var component in components)
            {
                int count = component.Value.Item2 * writeOffCount;
                IEnumerable<WareHouse> warehouses = source.WareHouses.Where(comp => comp.WareHouseComponents.ContainsKey(component.Key));

                foreach (WareHouse warehouse in warehouses)
                {
                    if (warehouse.WareHouseComponents[component.Key] <= count)
                    {
                        count -= warehouse.WareHouseComponents[component.Key];
                        warehouse.WareHouseComponents.Remove(component.Key);
                    }
                    else
                    {
                        warehouse.WareHouseComponents[component.Key] -= count;
                        count = 0;
                    }
                    if (count == 0)
                    {
                        break;
                    }
                }
            }
            return true;
        }

    }
}
