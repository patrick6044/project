using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Rental.Classes
{
    public class Masterhead
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public void Add_Masterhead(Models.MasterHead_model onNewMaster)
        {
            SqlCommand com = new SqlCommand("Sp_AddMasterhead", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Head ", onNewMaster.Head);
            com.Parameters.AddWithValue("@Body", onNewMaster.Body);
            com.Parameters.AddWithValue("@Date", onNewMaster.Date);
            // com.Parameters.AddWithValue("@MasterheadId", onNewMaster.MasterheadId);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
   
        }
        public void Update_MasterHead(Models.MasterHead_model onNewMaster)
        {
            SqlCommand com = new SqlCommand("Sp_UpdateMasterhead", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@MasterheadId", onNewMaster.MasterheadId);
            com.Parameters.AddWithValue("@Head ", onNewMaster.Head);
            com.Parameters.AddWithValue("@Body", onNewMaster.Body);
            
            con.Open();
            com.ExecuteNonQuery();
            con.Close();

        }  
        public DataSet Show_Masterhead_ById( int id)
        {
            SqlCommand com = new SqlCommand("Sp_getMasterhead", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@MasterheadId",id);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;


        }
        public DataSet Show_Masterhead()
        {
            SqlCommand com = new SqlCommand("Sp_getAllMasterhead", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }
        public void Delete_Masthead(int id)
        {
            SqlCommand com = new SqlCommand("Sp_DeleteMasterhead", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@MasterheadId", id);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();

        }

    }
} 