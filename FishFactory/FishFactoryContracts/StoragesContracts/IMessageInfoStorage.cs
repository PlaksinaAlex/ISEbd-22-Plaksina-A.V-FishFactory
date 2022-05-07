using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishFactoryContracts.BindingModels;
using FishFactoryContracts.ViewModels;

namespace FishFactoryContracts.StoragesContracts
{
	public interface IMessageInfoStorage
	{
		List<MessageInfoViewModel> GetFullList();
		List<MessageInfoViewModel> GetFilteredList(MessageInfoBindingModel model);
		void Insert(MessageInfoBindingModel model);
	}
}