using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Q_05
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        // ................. in this i had implemented the ACID properties by using two queries in one table 
        //...................which are executing simultaneously....!!!!@
        public void Display()
        {
            string connect = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            SqlConnection con = new SqlConnection(connect);
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from orders", con);
            SqlDataReader reader = cmd.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string connect = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlTransaction transact = con.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand("update orders set Quantity = Quantity - 1 where OID = 3",con,transact);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("update orders set Quantity = Quantity+1 where OID = 4",con,transact);
                cmd.ExecuteNonQuery();
                transact.Commit();
                Label1.Text="Transaction commited successfully .....!!!";
            }
            catch
            {
                transact.Rollback();
                Label1.Text = "Transaction is failed and rolled back to the previous state";
            }
            finally
            {
                con.Close();
            }

            Display();
        }
    }
}