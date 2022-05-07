using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Configuration;
using FishFactoryBusinessLogic.BusinessLogics;
using FishFactoryContracts.BusinessLogicsContracts;
using FishFactoryContracts.StoragesContracts;
using FishFactoryContracts.BindingModels;
using FishFactoryDatabaseImplement.Implements;
using FishFactoryBusinessLogic.MailWorker;
using FishFactoryBusinessLogic.OfficePackage;
using FishFactoryBusinessLogic.OfficePackage.Implements;
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
			var mailSender = Container.Resolve<AbstractMailWorker>();
			mailSender.MailConfig(new MailConfigBindingModel
			{
				MailLogin = ConfigurationManager.AppSettings["MailLogin"],
				MailPassword = ConfigurationManager.AppSettings["MailPassword"],
				SmtpClientHost = ConfigurationManager.AppSettings["SmtpClientHost"],
				SmtpClientPort = Convert.ToInt32(ConfigurationManager.AppSettings["SmtpClientPort"]),
				PopHost = ConfigurationManager.AppSettings["PopHost"],
				PopPort = Convert.ToInt32(ConfigurationManager.AppSettings["PopPort"])
			});
			var timer = new System.Threading.Timer(new TimerCallback(MailCheck), null, 0, 100000);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(Container.Resolve<FormMain>());
		}
		private static IUnityContainer BuildUnityContainer()
		{
			var currentContainer = new UnityContainer();
			currentContainer.RegisterType<IComponentStorage, ComponentStorage>(new 
			HierarchicalLifetimeManager());
			currentContainer.RegisterType<IOrderStorage, OrderStorage>(new
			HierarchicalLifetimeManager());
			currentContainer.RegisterType<ICannedStorage, CannedStorage>(new
			HierarchicalLifetimeManager());
			currentContainer.RegisterType<IImplementerStorage, ImplementerStorage>(new
			HierarchicalLifetimeManager());
			currentContainer.RegisterType<IComponentLogic, ComponentLogic>(new
			HierarchicalLifetimeManager());
			currentContainer.RegisterType<IClientStorage, ClientStorage>(new
			HierarchicalLifetimeManager());
			currentContainer.RegisterType<IMessageInfoStorage, MessageInfoStorage>(new
			HierarchicalLifetimeManager());

			currentContainer.RegisterType<IOrderLogic, OrderLogic>(new
			HierarchicalLifetimeManager());
			currentContainer.RegisterType<ICannedLogic, CannedLogic>(new
			HierarchicalLifetimeManager());
			currentContainer.RegisterType<IReportLogic, ReportLogic>(new
			HierarchicalLifetimeManager());
			currentContainer.RegisterType<IClientLogic, ClientLogic>(new
		    HierarchicalLifetimeManager());
			currentContainer.RegisterType<IImplementerLogic, ImplementerLogic>(new
			HierarchicalLifetimeManager());
			currentContainer.RegisterType<IWorkProcess, WorkModeling>(new
			HierarchicalLifetimeManager());
			currentContainer.RegisterType<IMessageInfoLogic, MessageInfoLogic>(new
			HierarchicalLifetimeManager());

			currentContainer.RegisterType<AbstractSaveToExcel, SaveToExcel>(new
			HierarchicalLifetimeManager());
			currentContainer.RegisterType<AbstractSaveToWord, SaveToWord>(new
			HierarchicalLifetimeManager());
			currentContainer.RegisterType<AbstractSaveToPdf, SaveToPdf>(new
			HierarchicalLifetimeManager());
			currentContainer.RegisterType<AbstractMailWorker, MailKitWorker>(new
			SingletonLifetimeManager());
			return currentContainer;
		}
		private static void MailCheck(object obj) => Container.Resolve<AbstractMailWorker>().MailCheck();
	}
}
