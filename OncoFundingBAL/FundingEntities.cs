using OncoFundingDAL;
using OncoFundingUtilities.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OncoFundingBAL
{
    public class FundingEntities : IFundingEntities
    {
        //public List<OncoFundingUtilities.ViewModels.CustomerDetail> GetCustomerDetail()
        //{
        //    FundingPortal fundingPortal = new FundingPortal();
        //    return fundingPortal.GetCustDataDAL().ToList();
        //}
        public List<OncoFundingUtilities.ViewModels.CustomerDetail> GetCustomerDetail()
        {
           
            FundingPortal fundingPortal = new FundingPortal();
              return fundingPortal.GetCustDataDAL().ToList();
        }

        public DataTable GetDataADO()
        {
            FundingWithADO fundingWithADO = new FundingWithADO();

            return fundingWithADO.GetDataFromADOCon();
        }
    }
}
