using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishFactoryContracts.BindingModels;
using FishFactoryContracts.ViewModels;


namespace FishFactoryContracts.BusinessLogicsContracts
{
	public interface IClientLogic
	{
		List<ClientViewModel> Read(ClientBindingModel model);

		void CreateOrUpdate(ClientBindingModel model);

		void Delete(ClientBindingModel model);
	}
}
