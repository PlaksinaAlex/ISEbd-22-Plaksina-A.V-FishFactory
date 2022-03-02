using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishFactoryContracts.BindingModels;
using FishFactoryContracts.ViewModels;

namespace FishFactoryContracts.BusinessLogicsContracts
{
	public interface IWareHouseLogic
	{
		List<WareHouseViewModel> Read(WareHouseBindingModel model);
		void CreateOrUpdate(WareHouseBindingModel model);
		void Delete(WareHouseBindingModel model);
		void Restocking(WareHouseRestockingBindingModel model);
	}
}
