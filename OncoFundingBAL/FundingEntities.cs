using OncoFundingDAL;
using OncoFundingUtilities.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Unity;


namespace OncoFundingBAL
{
    public class FundingEntities : IFundingEntities
    {
        IFundingEntities fundingEntities;
        IUnityContainer _unityContainer;
        public FundingEntities(IUnityContainer unityContainer)
        {
            _unityContainer = unityContainer;
            var ado = ConfigurationManager.AppSettings["DBAdo"];
            //var efdb = ConfigurationManager.AppSettings["EFDataModel"];

            
            if (ado == "DBAdo")
            {
                fundingEntities = _unityContainer.Resolve<IFundingEntities>("EFDB");
            }
            else
            {
                 fundingEntities = _unityContainer.Resolve<IFundingEntities>("ADO");
            }
        }

        public List<OncoFundingUtilities.ViewModels.CustomerDetail> GetCustomerDetail()
        {
            var d = fundingEntities.GetType();
            FundingPortal fundingPortal = new FundingPortal();
              return fundingPortal.GetCustDataDAL().ToList();
        }

        


    }
}
