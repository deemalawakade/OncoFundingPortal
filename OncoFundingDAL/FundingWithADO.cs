using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OncoFundingUtilities.ViewModels;
using System.Data.SqlClient;
using System.Data;

namespace OncoFundingDAL
{
  public class FundingWithADO : IFundingPortal
    {
        public DataTable GetDataFromADOCon()
        {
            SqlConnection con = new SqlConnection("Data Source=YH1008642DT\\SQLEXPRESS2014;Initial Catalog=OncoFundingPortal;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            SqlCommand cmd = new SqlCommand("select * from CustomerDetail", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Basic Salary");
            dt.Columns.Add("Hike");
            while (dr.Read())
            {
                dt.Rows.Add(dr["Id"], dr["Name"], dr["EmailId"], dr["Address"],dr["City"],dr["Phone"]);
            }

            return dt;
           
        }
        public List<OncoFundingUtilities.ViewModels.CustomerDetail> GetCustDataDAL()
        {
            throw new NotImplementedException();
        }
    }
}
