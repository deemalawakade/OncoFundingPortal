using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OncoFundingDAL
{
   public class FundingPortal
    {
        public List<OncoFundingUtilities.ViewModels.CustomerDetail> GetCustDataDAL()
        {
            //call this method in bal layer 
            
        OncoFundingPortalEntities dbObj = new OncoFundingPortalEntities();
            List<CustomerDetail> d = dbObj.CustomerDetails.ToList();
            OncoFundingUtilities.ViewModels.CustomerDetail customer = new OncoFundingUtilities.ViewModels.CustomerDetail();
            List<OncoFundingUtilities.ViewModels.CustomerDetail> q =
                new List<OncoFundingUtilities.ViewModels.CustomerDetail>();

            foreach (var k in d) {

                customer.Id = k.Id;
                customer.Name = k.Name;
                customer.EmailId = k.EmailId;
                customer.Address = k.Address;
                customer.City = k.City;
                customer.Phone=k.Phone;
                q.Add(customer);
            }
           
               
            return q;
        }
    }
}
