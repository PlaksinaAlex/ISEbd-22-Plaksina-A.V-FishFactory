using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FishFactoryBusinessLogic.BusinessLogics;
using FishFactoryContracts.BusinessLogicsContracts;
using FishFactoryContracts.StoragesContracts;
using FishFactoryDatabaseImplement.Implements;
using Unity;
using Unity.Lifetime;

namespace FishFactoryView
{
	static class Program
	{
		private static IUnityContainer container = null;
		public static IUnityContainer Container
		{
			get
			{
				if (container == null)
				{
					container = BuildUnityContainer();
				}
				return container;
			}
		}
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(Container.Resolve<FormMain>());
		}
		private static IUnityContainer BuildUnityContainer()
		{
			var currentContainer = new UnityContainer();
			currentContainer.RegisterType<IComponentStorage,
			ComponentStorage>(new HierarchicalLifetimeManager());
			currentContainer.RegisterType<IOrderStorage, OrderStorage>(new
			HierarchicalLifetimeManager());
			currentContainer.RegisterType<ICannedStorage, CannedStorage>(new
			HierarchicalLifetimeManager());
			currentContainer.RegisterType<IComponentLogic, ComponentLogic>(new
			HierarchicalLifetimeManager());
			currentContainer.RegisterType<IOrderLogic, OrderLogic>(new
			HierarchicalLifetimeManager());
			currentContainer.RegisterType<ICannedLogic, CannedLogic>(new
			HierarchicalLifetimeManager());
			return currentContainer;
		}
	}
}
