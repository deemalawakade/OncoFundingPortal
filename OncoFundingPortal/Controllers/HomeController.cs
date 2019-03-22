using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using OncoFundingPortal.Models;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace OncoFundingPortal.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            string Baseurl = "http://localhost:64264/api/Value";
            List<CustomerDetail> customerInfo = new List<CustomerDetail>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync(Baseurl);
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    customerInfo = JsonConvert.DeserializeObject<List<CustomerDetail>>(EmpResponse);

                }

            }
            return View(customerInfo);
        }

        



    }
}