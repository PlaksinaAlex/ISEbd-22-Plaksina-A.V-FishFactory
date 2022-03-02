using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishFactoryContracts.BusinessLogicsContracts;
using FishFactoryContracts.StoragesContracts;
using FishFactoryContracts.BindingModels;
using FishFactoryContracts.ViewModels;

namespace FishFactoryBusinessLogic.BusinessLogics
{
    public class WareHouseLogic : IWareHouseLogic
    {
        private readonly IWareHouseStorage _warehouseStorage;
        private readonly IComponentStorage _componentStorage;

        public WareHouseLogic(IWareHouseStorage warehouseStorage, IComponentStorage componentStorage)
        {
            _warehouseStorage = warehouseStorage;
            _componentStorage = componentStorage;
        }

        public List<WareHouseViewModel> Read(WareHouseBindingModel model)
        {
            if (model == null)
            {
                return _warehouseStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<WareHouseViewModel> { _warehouseStorage.GetElement(model) };
            }
            return _warehouseStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(WareHouseBindingModel model)
        {
            var element = _warehouseStorage.GetElement(new WareHouseBindingModel
            {
                WareHouseName = model.WareHouseName
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть склад с таким названием");
            }
            if (model.Id.HasValue)
            {
                _warehouseStorage.Update(model);
            }
            else
            {
                _warehouseStorage.Insert(model);
            }
        }
        public void Delete(WareHouseBindingModel model)
        {
            var element = _warehouseStorage.GetElement(new WareHouseBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Склад не найден");
            }
            _warehouseStorage.Delete(model);
        }

        public void Restocking(WareHouseRestockingBindingModel model)
        {
            var warehouse = _warehouseStorage.GetElement(new WareHouseBindingModel
            {
                Id = model.WareHouseId
            });
            if (warehouse == null)
            {
                throw new Exception("Склад не найден");
            }
            var component = _componentStorage.GetElement(new ComponentBindingModel
            {
                Id = model.ComponentId
            });
            if (component == null)
            {
                throw new Exception("Компонент не найден");
            }
            if (warehouse.WareHouseComponents.ContainsKey(model.ComponentId))
            {
                warehouse.WareHouseComponents[model.ComponentId] =
                (component.ComponentName, warehouse.WareHouseComponents[model.ComponentId].Item2 + model.Count);
            }
            else
            {
                warehouse.WareHouseComponents.Add(component.Id, (component.ComponentName, model.Count));
            }
            _warehouseStorage.Update(new WareHouseBindingModel
            {
                Id = warehouse.Id,
                WareHouseName = warehouse.WareHouseName,
                ResponsibleFace = warehouse.ResponsibleFace,
                DateCreate = warehouse.DateCreate,
                WareHouseComponents = warehouse.WareHouseComponents
            });
        }
    }
}
