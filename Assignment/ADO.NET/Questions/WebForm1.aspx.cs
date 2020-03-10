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
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            string connect = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            // in this code , i have implemented all object creations ....!!@


            //.................connection object............

            SqlConnection con = new SqlConnection(connect);


            //......................Execute reader object........

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from customer",con); //command object
            GridView1.DataSource = cmd.ExecuteReader();
            GridView1.DataBind();
            con.Close();


            //...........execute scalar method..........


            con.Open();
            SqlCommand cmd1 = new SqlCommand("select count(PID) from product", con); //command object
            int value = (int)cmd1.ExecuteScalar();
            Response.Write("\n\n\n\ntotal products in my table are : "+value);
            con.Close();

            //.........................execute non query......

            //con.Open();
            //SqlCommand cmd2 = new SqlCommand("insert into orders(OID,Quantity)values(9,3)", con); //command object
            //int row = (int)cmd2.ExecuteNonQuery();
            //Response.Write("\n\n\n\n\ntotal updated number of rows : " + row);
            //con.Close();

            //...............data reader.......
            con.Open();
            SqlCommand cmd3 = new SqlCommand("select * from product", con); //command object
            SqlDataReader reader = cmd3.ExecuteReader();
            GridView2.DataSource = reader;
            GridView2.DataBind();
            con.Close();

            //..............data addapter.............

            using (SqlDataAdapter adapt = new SqlDataAdapter("select * from orders", con))
            {
                con.Open();
                DataSet set = new DataSet();
                adapt.Fill(set);
                GridView3.DataSource = set;
                GridView3.DataBind();
                con.Close();
            }

           // Response.Write("Displaying three tables from disconnected and connected architecture: \n\n\n\n\n");


            //.........connected architecture........ // using data reader

            //con.Open();
            //SqlCommand cmd4 = new SqlCommand("select * from product;select * from orders", con); //command object
            //SqlDataReader readers = cmd4.ExecuteReader();
            //GridView4.DataSource = readers;
            //GridView4.DataBind();

            //while (readers.NextResult())
            //{
            //    GridView5.DataSource = readers;
            //    GridView5.DataBind();
            //}
            //con.Close();

            ////............................... disconnected architecture using data adapter.......



            //try
            //{
            //    SqlDataAdapter adapts = new SqlDataAdapter("select * from orders", con);
            //    con.Open();
            //    DataSet sets = new DataSet();
            //    adapts.Fill(sets);
            //    GridView6.DataSource = sets;
            //    GridView6.DataBind();
            //}
            //catch
            //{
            //    throw new Exception("some Exception is there");
            //}
            //finally
            //{
            //    con.Close();
            //}



        }
    }
}