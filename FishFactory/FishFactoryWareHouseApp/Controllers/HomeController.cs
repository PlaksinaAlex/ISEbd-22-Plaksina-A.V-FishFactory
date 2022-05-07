using FishFactoryWareHouseApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FishFactoryContracts.BindingModels;
using FishFactoryContracts.ViewModels;
using Microsoft.Extensions.Configuration;

namespace FishFactoryWareHouseApp.Controllers
{
	public class HomeController : Controller
	{
        private readonly ILogger<HomeController> _logger;

        private readonly IConfiguration configuration;
        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            this.configuration = configuration;
        }

        public IActionResult Index()
        {
            if (Program.Enter == null)
            {
                return Redirect("~/Home/Enter");
            }
            return View(APICllient.GetRequest<List<WareHouseViewModel>>("api/wareHouse/GetWareHouseList"));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult Enter()
        {
            return View();
        }

        [HttpPost]
        public void Enter(string password)
        {

            if (!string.IsNullOrEmpty(password))
            {
                if (configuration["Password"] != password)
                {
                    throw new Exception("Неверный пароль");
                }
                Program.Enter = true;
                Response.Redirect("Index");
                return;
            }
            throw new Exception("Введите логин, пароль");
        }

        [HttpGet]
        public IActionResult Create()
        {
            if (Program.Enter == false)
            {
                return Redirect("~/Home/Enter");
            }
            return View();
        }

        [HttpPost]
        public void Create(string wareHouseName, string responsibleFace)
        {
            if (!string.IsNullOrEmpty(wareHouseName) && !string.IsNullOrEmpty(responsibleFace))
            {
                APICllient.PostRequest("api/wareHouse/CreateOrUpdateWareHouse", new WareHouseBindingModel
                {
                    ResponsibleFace = responsibleFace,
                    WareHouseName = wareHouseName,
                    DateCreate = DateTime.Now,
                    WareHouseComponents = new Dictionary<int, (string, int)>()
                });
                Response.Redirect("Index");
                return;
            }
            throw new Exception("Введите название и ответственного");
        }

        [HttpGet]
        public IActionResult Update(int wareHouseId)
        {
            if (Program.Enter == false)
            {
                return Redirect("~/Home/Enter");
            }
            WareHouseViewModel wareHouse = APICllient.GetRequest<WareHouseViewModel>($"api/WareHouse/GetWareHouse?wareHouseId={wareHouseId}");
            ViewBag.Components = wareHouse.WareHouseComponents.Values;
            ViewBag.WareHouseName = wareHouse.WareHouseName;
            ViewBag.ResponsibleFace = wareHouse.ResponsibleFace;
            return View();
        }

        [HttpPost]
        public void Update(int wareHouseId, string wareHouseName, string responsibleFace)
        {
            if (String.IsNullOrEmpty(wareHouseName) || String.IsNullOrEmpty(responsibleFace))
            {
                return;
            }
            WareHouseViewModel wareHouse = APICllient.GetRequest<WareHouseViewModel>($"api/WareHouse/GetWareHouse?wareHouseId={wareHouseId}");
            APICllient.PostRequest("api/WareHouse/CreateOrUpdateWareHouse", new WareHouseBindingModel
            {
                Id = wareHouseId,
                WareHouseName = wareHouseName,
                ResponsibleFace = responsibleFace,
                WareHouseComponents = wareHouse.WareHouseComponents,
                DateCreate = DateTime.Now
            });
            Response.Redirect("Index");
        }

        [HttpGet]
        public IActionResult Delete()
        {
            if (Program.Enter == null)
            {
                return Redirect("~/Home/Enter");
            }
            ViewBag.WareHouse = APICllient.GetRequest<List<WareHouseViewModel>>("api/wareHouse/GetWareHouseList");
            return View();
        }

        [HttpPost]
        public void Delete(int wareHouseId)
        {
            var wareHouse = APICllient.GetRequest<WareHouseViewModel>($"api/WareHouse/GetWarehouse?warehouseId={wareHouseId}");
            APICllient.PostRequest("api/WareHouse/DeleteWareHouse", wareHouse);
            Response.Redirect("Index");
        }

        [HttpGet]
        public IActionResult AddComponent()
        {
            if (Program.Enter == null)
            {
                return Redirect("~/Home/Enter");
            }
            ViewBag.WareHouse = APICllient.GetRequest<List<WareHouseViewModel>>("api/wareHouse/GetWareHouseList");
            ViewBag.Component = APICllient.GetRequest<List<ComponentViewModel>>("api/wareHouse/GetComponents");
            return View();
        }

        [HttpPost]
        public void AddComponent(int wareHouseId, int componentId, int count)
        {
            APICllient.PostRequest("api/wareHouse/AddComponent", new WareHouseRestockingBindingModel
            {
                WareHouseId = wareHouseId,
                ComponentId = componentId,
                Count = count
            });
            Response.Redirect("Index");
        }
    }
}
