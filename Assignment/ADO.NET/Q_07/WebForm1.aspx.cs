using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

           
namespace Q_07
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connect = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            if(Cache["value"] == null)
            {
                using (SqlConnection con = new SqlConnection(connect))
                {
                    SqlDataAdapter ada = new SqlDataAdapter("select * from orders",con);
                    DataSet ds = new DataSet();
                    ada.Fill(ds);

                    GridView1.DataSource = ds;
                    GridView1.DataBind();

                    Cache["value"] = ds;
                    Label1.Text = "data is loaded from the DB";
                }
            }
            else
            {
                GridView2.DataSource = (DataSet)Cache["value"];
                GridView2.DataBind();
                Label1.Text = "data is loaded from the cache only.....!!";
            }
        }
    }
}