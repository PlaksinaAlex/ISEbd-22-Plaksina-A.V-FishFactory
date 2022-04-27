using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishFactoryContracts.ViewModels;

namespace FishFactoryBusinessLogic.OfficePackage.HelperModels
{
    public class WordInfoWareHouses
    {
        public string FileName { get; set; }

        public string Title { get; set; }

        public List<WareHouseViewModel> WareHouses { get; set; }
    }
}
