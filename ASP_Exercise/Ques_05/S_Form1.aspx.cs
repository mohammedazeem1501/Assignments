using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ques_05
{
    public partial class S_Form1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["username"] = TextBox1.Text;
            Session["pass"] = TextBox2.Text;
            ViewState["user"] = TextBox3.Text;
            ViewState["passwrd"] = TextBox4.Text;
            Response.Redirect("S_Form2.aspx");
        }
    }
}