using System.Web.Http;

namespace SalesFiguresAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values/5
        public int[] Get(int id)
        {
            return new int[] { 47, 33, 23, 100 };
        }
    }
}
