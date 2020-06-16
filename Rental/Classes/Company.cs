using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Rental.Classes
{
    public class Company
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public void Add_Company(Models.Company_model onNewCompany)

        {
            SqlCommand com = new SqlCommand("Sp_AddCompany", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@CompanyName", onNewCompany.CompanyName);
            com.Parameters.AddWithValue("@Location", onNewCompany.Location);
            com.Parameters.AddWithValue("@Phone", onNewCompany.Phone);
            com.Parameters.AddWithValue("@Email", onNewCompany.Email);
            com.Parameters.AddWithValue("@Facebook", onNewCompany.Facebook);
            com.Parameters.AddWithValue("@Twitter", onNewCompany.Twitter);
            com.Parameters.AddWithValue("@Whatsapp", onNewCompany.@Whatsapp);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();

        }
        public void Update_Company(Models.Company_model onNewCompany)
        {
            SqlCommand com = new SqlCommand("Sp_UpdateCompany", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@CompanyId", onNewCompany.CompanyId);
            com.Parameters.AddWithValue("@CompanyName", onNewCompany.CompanyName);
            com.Parameters.AddWithValue("@Location", onNewCompany.Location);
            com.Parameters.AddWithValue("@Phone", onNewCompany.Phone);
            com.Parameters.AddWithValue("@Email", onNewCompany.Email);
            com.Parameters.AddWithValue("@Facebook", onNewCompany.Facebook);
            com.Parameters.AddWithValue("@Twitter", onNewCompany.Twitter);
            com.Parameters.AddWithValue("@Whatsapp", onNewCompany.@Whatsapp);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();

        }
        public DataSet ViewCompany_ById(int id)
        {
            SqlCommand com = new SqlCommand("Sp_getCompany ", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@CompanyId", id);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public DataSet ViewCompany()
        {
            SqlCommand com = new SqlCommand("Sp_getAllCompany", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }
        public void Delete_Company(int id)
        {
            SqlCommand com = new SqlCommand("Sp_DeleteCompany", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@CompanyId", id);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();

        }
    }
}