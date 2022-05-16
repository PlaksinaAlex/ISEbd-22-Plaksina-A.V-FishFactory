using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using FishFactoryContracts.Attributes;

namespace FishFactoryContracts.ViewModels
{
	public class ComponentViewModel
	{
		public int Id { get; set; }

		[Column(title: "Название компонента", gridViewAutoSize: GridViewAutoSize.Fill)] 
		public string ComponentName { get; set; }
	}
}
