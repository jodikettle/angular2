using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDispatchRepository : IOrderDispatchRepository
    {
        public DispatchInformation GetDispatchInformation()
        {
            return new DispatchInformation()
            {
                NumberOfDispatches = 4,
                NumberOfNillPicks = 2
            };
        }
    }
}
