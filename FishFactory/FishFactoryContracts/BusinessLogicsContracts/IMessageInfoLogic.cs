using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishFactoryContracts.BindingModels;
using FishFactoryContracts.ViewModels;

namespace FishFactoryContracts.BusinessLogicsContracts
{
	public interface IMessageInfoLogic
	{
		List<MessageInfoViewModel> Read(MessageInfoBindingModel model);
		void CreateOrUpdate(MessageInfoBindingModel model);
	}
}