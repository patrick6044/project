using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Rental.Classes
{
    public class Comment
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public void MyWebsite(Models.Comment_model onNewComment)
        {
            SqlCommand com = new SqlCommand("Sp_AddComment", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Name", onNewComment.Name);
            com.Parameters.AddWithValue("@Email", onNewComment.Email);
            com.Parameters.AddWithValue("@Date", onNewComment.Date);
            com.Parameters.AddWithValue("@Message", onNewComment.Message);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();

        }
        public void Update_Comment(Models.Comment_model onNewComment)
        {
            SqlCommand com = new SqlCommand("Sp_UpdateComment", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@CommentId", onNewComment.CommentId);
            com.Parameters.AddWithValue("@Name", onNewComment.Name);
            com.Parameters.AddWithValue("@Email", onNewComment.Email);
            
            com.Parameters.AddWithValue("@Comment", onNewComment.Message);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();

        }
        public DataSet Show_Comment_ById(int id)
        {
            SqlCommand com = new SqlCommand("Sp_getComment", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@CommentId",id);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }
        public DataSet Dashboard()
        {
            SqlCommand com = new SqlCommand("Sp_getAllComment", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }
        public void DeleteComment(int id)
        {
            SqlCommand com = new SqlCommand("Sp_DeleteComment", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@CommentId", id);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();

        }
    }
}