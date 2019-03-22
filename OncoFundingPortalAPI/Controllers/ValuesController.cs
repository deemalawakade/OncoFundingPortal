using OncoFundingUtilities;
using OncoFundingBAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OncoFundingUtilities.ViewModels;


namespace OncoFundingPortalAPI.Controllers
{
    public class ValuesController : ApiController
    {
        //GET api/values
        List<CustomerDetail> u = new List<CustomerDetail>();
        public List<CustomerDetail> Get()
        {
            FundingEntities funding = new FundingEntities();
            u = funding.GetCustomerDetail();
            return u;
        }
       
        
        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
