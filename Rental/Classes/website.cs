using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Rental.Classes
{
    public class Website
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public DataSet ViewCompany()
        {
            SqlCommand com = new SqlCommand("Sp_getAllCompany", con);
            SqlCommand comH = new SqlCommand("Sp_getAllMasterhead", con);
            SqlCommand comA = new SqlCommand("Sp_getAllWAbout", con);

            com.CommandType = CommandType.StoredProcedure;
            comH.CommandType = CommandType.StoredProcedure;
            comA.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(com);
            SqlDataAdapter daH = new SqlDataAdapter(comH);
            SqlDataAdapter daA = new SqlDataAdapter(comA);

            DataSet ds = new DataSet();
            daH.Fill(ds);
            da.Fill(ds);
            daA.Fill(ds);

            return ds;
         

        }





    }
}