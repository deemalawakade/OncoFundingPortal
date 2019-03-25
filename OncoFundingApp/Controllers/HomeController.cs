using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


namespace OncoFundingApp.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            //GetCustomer();
            return "abc";
        }

       
        public async Task<ActionResult> GetCustomer()
        {

            IEnumerable<OncoFundingUtilities.ViewModels.CustomerDetail> customerInfo= new List<OncoFundingUtilities.ViewModels.CustomerDetail>(); ;
            //
            using (var client = new HttpClient())
            {
                var url = "http://localhost:64264/api/values";
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync(url);
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    customerInfo = JsonConvert.DeserializeObject<List<OncoFundingUtilities.ViewModels.CustomerDetail>>(EmpResponse);

                }

            }
            return View(customerInfo);
        }
    }
}