using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Q8
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtUsername.Focus();
            }

        }

        protected void RegisterUser(object sender, EventArgs e)
        {
            string connect = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connect))
            {
                 
                SqlCommand cmd = new SqlCommand("insert into form_data(username,age,pass,email) values(@user,@age,@pass,@email)", con);
                cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                cmd.Parameters.AddWithValue("@age", txtage.Text);
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                try
                {
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        Label1.Text = "Data inserted successfully.........!!!!!";
                        con.Close();
                    }
                    catch (SqlException)
                    {
                        Console.WriteLine("Sql Exception occurred");
                    }

                }
                catch (Exception)
                {

                    Console.WriteLine("Exception Occurred");
                }
                SqlCommand cmd1 = new SqlCommand("select * from form_data", con);
                con.Open();
                GridView1.DataSource=cmd1.ExecuteReader();
                GridView1.DataBind();
                con.Close();

            }
        }

        protected void Button1_Command(object sender, CommandEventArgs e)
        {
            switch(e.CommandName)
            {
                case "Button1":
                    Label2.Text = "first button clicked and it is showing the command line event of a button";
                    break;
                case "Button2":
                    Label3.Text = "Second button clicked and it is also showing the command line event of a button";
                    break;

            }
        }

        
    }
}