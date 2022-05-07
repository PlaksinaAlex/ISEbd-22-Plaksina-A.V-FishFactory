using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FishFactoryContracts.BindingModels;
using FishFactoryContracts.BusinessLogicsContracts;
using FishFactoryContracts.ViewModels;

namespace FishFactoryRestApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WareHouseController : Controller
    {
        private readonly IWareHouseLogic _wareHouse;

        private readonly IComponentLogic _component;

        public WareHouseController(IWareHouseLogic wareHouse, IComponentLogic component)
        {
            _wareHouse = wareHouse;
            _component = component;
        }

        [HttpGet]
        public List<WareHouseViewModel> GetWareHouseList() => _wareHouse.Read(null)?.ToList();

        [HttpGet]
        public WareHouseViewModel GetWareHouse(int wareHouseId) => _wareHouse.Read(new WareHouseBindingModel { Id = wareHouseId })?[0];

        [HttpGet]
        public List<ComponentViewModel> GetComponents() => _component.Read(null);

        [HttpPost]
        public void CreateOrUpdateWareHouse(WareHouseBindingModel model) => _wareHouse.CreateOrUpdate(model);

        [HttpPost]
        public void DeleteWareHouse(WareHouseBindingModel model) => _wareHouse.Delete(model);

        [HttpPost]
        public void AddComponent(WareHouseRestockingBindingModel model) => _wareHouse.Restocking(model);
    }
}