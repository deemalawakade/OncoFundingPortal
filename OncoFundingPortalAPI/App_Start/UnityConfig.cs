using OncoFundingBAL;
using OncoFundingDAL;
using System.Configuration;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace OncoFundingPortalAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
           
            container.RegisterType<IFundingEntities, FundingEntities>("EFDB");
            container.RegisterType<IFundingEntities, FundingWithADO>("ADO");
           
            

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
          
        }
    }
}