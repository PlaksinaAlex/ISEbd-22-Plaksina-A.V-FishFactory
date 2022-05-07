﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishFactoryListImplement.Models;

namespace FishFactoryListImplement
{
	public class DataListSingleton
	{
		private static DataListSingleton instance;
		public List<Component> Components { get; set; }
		public List<Order> Orders { get; set; }
		public List<Canned> Canneds { get; set; }
		public List<Client> Clients { get; set; }
		public List<Implementer> Implementers { get; set; }
		public List<MessageInfo> MessageInfoes { get; set; }
		private DataListSingleton()
		{
			Components = new List<Component>();
			Orders = new List<Order>();
			Canneds = new List<Canned>();
			Clients = new List<Client>();
			Implementers = new List<Implementer>();
			MessageInfoes = new List<MessageInfo>();
		}
		public static DataListSingleton GetInstance()
		{
			if (instance == null)
			{
				instance = new DataListSingleton();
			}
			return instance;
		}

	}
}
