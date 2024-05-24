using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace AWMobileAPI.Controllers
{
    [RoutePrefix("api/shared/listing")]
    public class SharedListingController : ApiController
    {
        [HttpGet]
        [Route("GetListings")]
        public IEnumerable<string> GetListings()
        {
            return new string[] { "GetListings", "GetListings2" };
        }
    }
}
