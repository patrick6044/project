using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Rental.Classes
{
    public class About
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        public void Add_About(Models.About oAbout)
        {
            SqlCommand com = new SqlCommand("Sp_AddAbout", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Title", oAbout.ATitle);
            com.Parameters.AddWithValue("@Body", oAbout.ABody);
            com.Parameters.AddWithValue("@Date", oAbout.Date);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();

        }
        public void Update_About(Models.About oAbout)
        {
            SqlCommand com = new SqlCommand("Sp_UpdateAbout", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@AboutId", oAbout.AboutId);
            com.Parameters.AddWithValue("@ATitle", oAbout.ATitle);
            com.Parameters.AddWithValue("@Body", oAbout.ABody);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();

        }
        public DataSet Show_About_ById(int id)
        {
            SqlCommand com = new SqlCommand("Sp_getAbout", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@AboutId", id);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }
        public DataSet Show_About()
        {
            SqlCommand com = new SqlCommand("Sp_getAllAbout", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }
        public  void Delete_About(int id)
        {
            SqlCommand com = new SqlCommand("Sp_DeleteAbout", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@AboutId", id);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
                
        }
    }
}