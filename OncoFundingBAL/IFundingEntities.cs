using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OncoFundingBAL
{
    public interface IFundingEntities
    {
        List<OncoFundingUtilities.ViewModels.CustomerDetail> GetCustomerDetail();
        //{
        //    //FundingPortal fundingPortal = new FundingPortal();
        //    //return fundingPortal.GetCustDataDAL().ToList();
        //}
    }
}
