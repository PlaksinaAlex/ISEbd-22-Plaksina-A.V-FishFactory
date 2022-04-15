using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishFactoryContracts.Enums;
using FishFactoryFileImplement.Models;
using System.IO;
using System.Xml.Linq;

namespace FishFactoryFileImplement
{
	public class FileDataListSingleton
	{
		private static FileDataListSingleton instance;

		private readonly string ComponentFileName = "Component.xml";

		private readonly string OrderFileName = "Order.xml";

		private readonly string CannedFileName = "Canned.xml";

		private readonly string ClientFileName = "Client.xml";
		public List<Component> Components { get; set; }
		public List<Order> Orders { get; set; }
		public List<Canned> Canneds { get; set; }

		public List<Client> Clients { get; set; }
		private FileDataListSingleton()
		{
			Components = LoadComponents();
			Orders = LoadOrders();
			Canneds = LoadCanneds();
			Clients = LoadClients();
		}
		public static FileDataListSingleton GetInstance()
		{
			if (instance == null)
			{
				instance = new FileDataListSingleton();
			}
			return instance;
		}
		public static void FileDataListSingletonSave()
		{
			instance.SaveComponents();
			instance.SaveOrders();
			instance.SaveCanneds();
			instance.SaveClients();

		}
		private List<Component> LoadComponents()
		{
			var list = new List<Component>();
			if (File.Exists(ComponentFileName))
			{
				var xDocument = XDocument.Load(ComponentFileName);
				var xElements = xDocument.Root.Elements("Component").ToList();
				foreach (var elem in xElements)
				{
					list.Add(new Component
					{
						Id = Convert.ToInt32(elem.Attribute("Id").Value),
						ComponentName = elem.Element("ComponentName").Value
					});
				}
			}
			return list;
		}
		private List<Order> LoadOrders()
		{
			var list = new List<Order>();
			if (File.Exists(OrderFileName))
			{
				XDocument xDocument = XDocument.Load(OrderFileName);
				var xElements = xDocument.Root.Elements("Order").ToList();

				foreach (var elem in xElements)
				{
					OrderStatus status = 0;
					switch (elem.Element("Status").Value)
					{
						case "Принят":
							status = OrderStatus.Принят;
							break;
						case "Выполняется":
							status = OrderStatus.Выполняется;
							break;
						case "Готов":
							status = OrderStatus.Готов;
							break;
						case "Оплачен":
							status = OrderStatus.Выдан;
							break;
					}

					list.Add(new Order
					{
						Id = Convert.ToInt32(elem.Attribute("Id").Value),
						ClientId = Convert.ToInt32(elem.Element("ClientId").Value),
						CannedId = Convert.ToInt32(elem.Element("CannedId").Value),
						Count = Convert.ToInt32(elem.Element("Count").Value),
						Sum = Convert.ToDecimal(elem.Element("Sum").Value),
						Status = status,
						DateCreate = Convert.ToDateTime(elem.Element("DateCreate").Value),
						DateImplement = string.IsNullOrEmpty(elem.Element("DateImplement").Value) ?
						(DateTime?)null : Convert.ToDateTime(elem.Element("DateImplement").Value),
					});
				}
			}
			return list;
		}
		private List<Canned> LoadCanneds()
		{
			var list = new List<Canned>();
			if (File.Exists(CannedFileName))
			{
				var xDocument = XDocument.Load(CannedFileName);
				var xElements = xDocument.Root.Elements("Canned").ToList();
				foreach (var elem in xElements)
				{
					var cannComp = new Dictionary<int, int>();
					foreach (var component in elem.Element("CannedComponents").Elements("CannedComponent").ToList())
					{
						cannComp.Add(Convert.ToInt32(component.Element("Key").Value),
					   Convert.ToInt32(component.Element("Value").Value));
					}
					list.Add(new Canned
					{
						Id = Convert.ToInt32(elem.Attribute("Id").Value),
						CannedName = elem.Element("CannedName").Value,
						Price = Convert.ToDecimal(elem.Element("Price").Value),
						CannedComponents = cannComp
					});
				}
			}
			return list;
		}
		private List<Client> LoadClients()
		{
			var list = new List<Client>();

			if (File.Exists(ClientFileName))
			{
				XDocument xDocument = XDocument.Load(ClientFileName);
				var xElements = xDocument.Root.Elements("Client").ToList();

				foreach (var client in xElements)
				{
					list.Add(new Client
					{
						Id = Convert.ToInt32(client.Attribute("Id").Value),
						ClientFIO = client.Element("ClientFIO").Value,
						Email = client.Element("Email").Value,
						Password = client.Element("Password").Value,
					});
				}
			}
			return list;
		}
		private void SaveComponents()
		{
			if (Components != null)
			{
				var xElement = new XElement("Components");
				foreach (var component in Components)
				{
					xElement.Add(new XElement("Component", new XAttribute("Id", component.Id),
					new XElement("ComponentName", component.ComponentName)));
				}
				var xDocument = new XDocument(xElement);
				xDocument.Save(ComponentFileName);
			}
		}
		private void SaveOrders()
		{
			if (Orders != null)
			{
				var xElement = new XElement("Orders");
				foreach (var order in Orders)
				{
					xElement.Add(new XElement("Order",
					new XAttribute("Id", order.Id),
					new XElement("ClientId", order.ClientId),
					new XElement("CannedId", order.CannedId),
					new XElement("Count", order.Count),
					new XElement("Sum", order.Sum),
					new XElement("Status", order.Status),
					new XElement("DateCreate", order.DateCreate),
					new XElement("DateImplement", order.DateImplement)));

				}
				XDocument xDocument = new XDocument(xElement);
				xDocument.Save(OrderFileName);
			}
		}
		private void SaveCanneds()
		{
			if (Canneds != null)
			{
				var xElement = new XElement("Canneds");
				foreach (var canned in Canneds)
				{
					var compElement = new XElement("CannedComponents");
					foreach (var component in canned.CannedComponents)
					{
						compElement.Add(new XElement("CannedComponent", new XElement("Key", component.Key),
						new XElement("Value", component.Value)));
					}
					xElement.Add(new XElement("Canned",
					 new XAttribute("Id", canned.Id),
					 new XElement("CannedName", canned.CannedName),
					 new XElement("Price", canned.Price),
					 compElement));
				}
				var xDocument = new XDocument(xElement);
				xDocument.Save(CannedFileName);
			}
		}
		private void SaveClients()
		{
			if (Clients != null)
			{
				var xElement = new XElement("Clients");

				foreach (var client in Clients)
				{
					xElement.Add(new XElement("Client",
					new XAttribute("Id", client.Id),
					new XElement("ClientFIO", client.ClientFIO),
					new XElement("Email", client.Email),
					new XElement("Password", client.Password)));
				}

				XDocument xDocument = new XDocument(xElement);
				xDocument.Save(ClientFileName);
			}
		}
	}
}
