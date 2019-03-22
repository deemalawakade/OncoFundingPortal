using OncoFundingDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OncoFundingBAL
{
   public class FundingEntities
    {
        public List<OncoFundingUtilities.ViewModels.CustomerDetail> GetCustomerDetail()
        {
            FundingPortal fundingPortal = new FundingPortal();
            return fundingPortal.GetCustDataDAL().ToList();
        }
    }
}
