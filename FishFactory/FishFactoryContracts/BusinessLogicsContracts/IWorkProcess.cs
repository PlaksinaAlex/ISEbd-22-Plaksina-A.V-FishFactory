using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishFactoryContracts.BusinessLogicsContracts
{
    public interface IWorkProcess
    {
        void DoWork(IImplementerLogic implementerLogic, IOrderLogic orderLogic);
    }
}
