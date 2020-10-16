using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EF.Diagnostics.Profiling;
using NanoProfilerSandBox.Respository;

namespace NanoProfilerSandBox.Controllers
{
    public class CustomController : ApiController
    {
        private CustomersRepository _CustomersRepository;
        public CustomController()
        {
            _CustomersRepository = new CustomersRepository();
        }

        [Route("~/Customers")]
        public IEnumerable<string> Get()
        {
            var result = new List<string>();
            using (ProfilingSession.Current.Step("CustomController.Get()"))
            {
                result = _CustomersRepository.GetCustomerContactName();
            }
            return result;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}