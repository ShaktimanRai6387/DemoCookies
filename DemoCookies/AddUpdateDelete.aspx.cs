using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoCookies
{
    public partial class AddUpdateDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["shakti"].ConnectionString);
            if (con.State == ConnectionState.Closed)
                con.Open();
             SqlCommand cmd = new SqlCommand("sp_Insertstudent",con);
             cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Class", txtClass.Text);
            cmd.Parameters.AddWithValue("@Section", txtSection.Text);
            cmd.Parameters.AddWithValue("@RoolNo", txtRoolNo.Text);
            if (cmd.ExecuteNonQuery() == 1)
            {
                con.Close();
                Label1.Text = "Record Saved Successfully";
            }
            else
            {
                con.Close();
                Label1.Text = "Record Not Saved___try again";
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["shakti"].ConnectionString);
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("sp_Updatestudent", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Class", txtClass.Text);
            cmd.Parameters.AddWithValue("@Section", txtSection.Text);
            cmd.Parameters.AddWithValue("@RoolNo", txtRoolNo.Text);
            if (cmd.ExecuteNonQuery() == 1)
            {
                con.Close();
                Label1.Text = "Record Update Successfully";
            }
            else
            {
                con.Close();
                Label1.Text = "Record Not Update___try again";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["shakti"].ConnectionString);
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("sp_Deletestudent", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));
            if (cmd.ExecuteNonQuery() == 1)
            {
                con.Close();
                Label1.Text = "Record Update Successfully";
            }
            else
            {
                con.Close();
                Label1.Text = "Record Not Update___try again";
            }
        }
    }
}