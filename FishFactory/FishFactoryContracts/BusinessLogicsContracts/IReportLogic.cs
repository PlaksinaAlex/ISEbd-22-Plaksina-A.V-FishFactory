using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishFactoryContracts.BindingModels;
using FishFactoryContracts.ViewModels;

namespace FishFactoryContracts.BusinessLogicsContracts
{
	public interface IReportLogic
	{
		List<ReportCannedComponentViewModel> GetCannedComponent();
		List<ReportOrdersViewModel> GetOrders(ReportBindingModel model);
		List<ReportOrdersByDateViewModel> GetOrdersByDate();
		List<ReportWareHouseComponentViewModel> GetWareHouseComponent();
		void SaveCannedsToWordFile(ReportBindingModel model);
		void SaveWareHousesToWordFile(ReportBindingModel model);
		void SaveCannedComponentToExcelFile(ReportBindingModel model);
		void SaveWareHouseComponentToExcelFile(ReportBindingModel model);
		void SaveOrdersToPdfFile(ReportBindingModel model);
		void SaveOrdersByDateToPdfFile(ReportBindingModel model);

	}
}
