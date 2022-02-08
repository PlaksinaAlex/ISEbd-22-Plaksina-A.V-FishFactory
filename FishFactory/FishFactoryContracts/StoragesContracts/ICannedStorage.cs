using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishFactoryContracts.BindingModels;
using FishFactoryContracts.ViewModels;

namespace FishFactoryContracts.StoragesContracts
{
	public interface ICannedStorage
	{
		List<CannedViewModel> GetFullList();
		List<CannedViewModel> GetFilteredList(CannedBindingModel model);
		CannedViewModel GetElement(CannedBindingModel model);
		void Insert(CannedBindingModel model);
		void Update(CannedBindingModel model);
		void Delete(CannedBindingModel model);
	}
}
