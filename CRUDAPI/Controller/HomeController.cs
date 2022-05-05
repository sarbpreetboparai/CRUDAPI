using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CRUDAPI.Controller
{
    [BasicAuth]
    public class HomeController : ApiController
    {
        private SynCustoms entities = new SynCustoms();
        [HttpGet]
        public HttpResponseMessage GetCustomer()
        {
            List<Customer> result = new List<Customer>();
            result = entities.Customer.ToList();

            return Request.CreateResponse(HttpStatusCode.OK, result);

        }
    }
}
