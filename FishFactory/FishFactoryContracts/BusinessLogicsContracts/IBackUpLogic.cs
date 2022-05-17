using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishFactoryContracts.BindingModels;

namespace FishFactoryContracts.BusinessLogicsContracts
{
	public interface IBackUpLogic
	{
		void CreateBackUp(BackUpSaveBinidngModel model);
	}
}
