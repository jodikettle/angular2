using SalesFiguresAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesFiguresAPI.Services
{
    public interface IOrderDispatchService
    {
        DispatchInfoViewModel GetDispatchInformation();
    }
}
