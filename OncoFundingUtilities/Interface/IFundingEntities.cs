using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OncoFundingUtilities.ViewModels;
namespace OncoFundingBAL
{
    public interface IFundingEntities
    {
        List<CustomerDetail> GetCustomerDetail();
      
    }
}
