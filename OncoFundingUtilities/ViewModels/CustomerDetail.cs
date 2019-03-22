using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OncoFundingUtilities.ViewModels
{
    public class CustomerDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public Nullable<decimal> Phone { get; set; }
    }
}
