using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OncoFundingUtilities.ViewModels;
using System.Data.SqlClient;
using System.Data;
using OncoFundingBAL;

namespace OncoFundingDAL
{
  public class FundingWithADO : IFundingEntities
    {
       
        //public List<OncoFundingUtilities.ViewModels.CustomerDetail> GetCustDataDAL()
        //{
            
        //}

        public List<OncoFundingUtilities.ViewModels.CustomerDetail> GetCustomerDetail()
        {
            SqlConnection con = new SqlConnection("Data Source=YH1008642DT\\SQLEXPRESS2014;Initial Catalog=OncoFundingPortal;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            SqlCommand cmd = new SqlCommand("select * from CustomerDetail", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            List<OncoFundingUtilities.ViewModels.CustomerDetail> custList = new List<OncoFundingUtilities.ViewModels.CustomerDetail>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                OncoFundingUtilities.ViewModels.CustomerDetail student = new OncoFundingUtilities.ViewModels.CustomerDetail();
                student.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                student.Name = dt.Rows[i]["Name"].ToString();
                student.EmailId = dt.Rows[i]["EmailId"].ToString();
                student.Address = dt.Rows[i]["Address"].ToString();
                student.City = dt.Rows[i]["City"].ToString();
                student.Phone = Convert.ToDecimal(dt.Rows[i]["Phone"]);
                custList.Add(student);
            }
            return custList;
        }
    }
}
