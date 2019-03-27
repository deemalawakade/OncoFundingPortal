using OncoFundingBAL;
using OncoFundingDAL;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace OncoFundingPortalAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

         
            container.RegisterType<IFundingEntities, FundingEntities>();
            container.RegisterType<IFundingPortal, FundingPortal>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

        }
    }
}