using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishFactoryContracts.BindingModels;
using FishFactoryContracts.ViewModels;

namespace FishFactoryContracts.BusinessLogicsContracts
{
	public interface ICannedLogic
	{
		List<CannedViewModel> Read(CannedBindingModel model);
		void CreateOrUpdate(CannedBindingModel model);
		void Delete(CannedBindingModel model);
	}
}
