using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishFactoryBusinessLogic.OfficePackage.HelperModels
{
    public class WordTableRow
    {
        public List<WordTableCell> Cells { get; set; }
        public bool Bolded { get; set; }
    }
}
