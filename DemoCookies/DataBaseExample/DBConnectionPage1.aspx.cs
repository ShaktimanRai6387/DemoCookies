using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoCookies.DataBaseExample
{
    public partial class DBConnectionPage1 : System.Web.UI.Page
    {
        string ID, Name, Class, Section, RoolNo = null;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //1 Create Connection
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["shakti"].ConnectionString);

            //2 Open  Connection
            if (con.State == ConnectionState.Closed)
                con.Open();

            // 3 Create a Command

            SqlCommand cmd = new SqlCommand("select ID,Name,Class,Section,RoolNo from lbl_student", con);

            //4 Execute Command

            GridView1.DataSource = cmd.ExecuteReader();
            GridView1.DataBind();

            // 5 Connection Close

            if (con.State == ConnectionState.Open)
                con.Close();

        }

        protected void btnExecuteReder_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["shakti"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select ID,Name,Class,Section,RoolNo from lbl_student", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            StringBuilder sb = new StringBuilder();
            sb.Append("<table border='1' align=center'>");
            sb.Append("<caption> Student Detials</caption>");
            sb.Append("<tr>");
            for (int i = 0; i < dr.FieldCount; i++)
            {
                sb.Append("<th>" + dr.GetName(i) + "</th>");
            }
            sb.Append("</tr>");

            while (dr.Read())
            {
                sb.Append("<tr>");
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    sb.Append("<td>" + dr[i] + "</td> ");
                }
                sb.Append("</tr>");
            }
            sb.Append("</table>");
            con.Close();
            Response.Write(sb);
        }

        protected void btnSearchRoolNo_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["shakti"].ConnectionString);
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("select ID,Name,Class,Section,RoolNo from lbl_student where RoolNo=8", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                 ID = dr["ID"].ToString();
                 Name = dr["Name"].ToString();
                 Class = dr["Class"].ToString();
                 Section = dr["Section"].ToString();
                 RoolNo = dr["RoolNo"].ToString();
            }
            con.Close();
            Response.Write("ID:<span style='color:red;'><b>" + ID + "</b></span></br>");
            Response.Write("Name:<span style='color:red;'><b>" + Name + "</b></span></br>");
            Response.Write("Class:<span style='color:red;'><b>" + Class + "</b></span></br>");
            Response.Write("Section:<span style='color:red;'><b>" + Section + "</b></span></br>");
            Response.Write("RoolNo:<span style='color:red;'><b>" + RoolNo + "</b></span></br>");
        }
    }
}