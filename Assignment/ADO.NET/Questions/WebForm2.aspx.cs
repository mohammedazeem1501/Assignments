using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace Questions
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connect = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            // .........connected architecture........ // using data reader
            //............it has implementation of Q_10 also such it is showing the two types of object creating...
            SqlConnection con = new SqlConnection(connect);
            try
            {
                con.Open();
                SqlCommand cmd4 = new SqlCommand("select * from product;select * from orders", con); //command object
                SqlDataReader readers = cmd4.ExecuteReader();
                GridView1.DataSource = readers;
                GridView1.DataBind();

                while (readers.NextResult())
                {
                    GridView2.DataSource = readers;
                    GridView2.DataBind();
                }
                con.Close();
            }
            catch 
            {

                throw new Exception("Exception will be handled here...");
            }
            finally
            {
                con.Close();
            }

            //............................... disconnected architecture using data adapter.......

            //.....it is another method of connection establishment by using method 
            //... in this we don't have to open and close as it will be done implicitly...

            using (SqlDataAdapter adapts = new SqlDataAdapter("select * from customer", con))
            {  
                DataSet sets = new DataSet();
                adapts.Fill(sets);
                GridView3.DataSource = sets;
                GridView3.DataBind();
            }
           
            }
        }
    }
