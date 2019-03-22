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

            List<OncoFundingUtilities.ViewModels.CustomerDetail> q =
                new List<OncoFundingUtilities.ViewModels.CustomerDetail>();

            foreach (var k in d) {
                q.Add(new OncoFundingUtilities.ViewModels.CustomerDetail() {Id =k.Id });

            }
            return q;
        }
    }
}
