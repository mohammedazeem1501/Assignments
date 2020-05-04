using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ques_01
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        double number=0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn1_Click(object sender, EventArgs e)
        {
            Button myButton = sender as Button;
            txt.Text = txt.Text+myButton.Text;
        }

        protected void add(object sender, EventArgs e)
        {
            Button myButton = sender as Button;
            temp2.Value =myButton.Text;
            temp.Value = txt.Text;
            double number = Convert.ToDouble(txt.Text);
            txt.Text = string.Empty;
        }

        protected void result(object sender, EventArgs e)
        {
            double Result = 0;
            switch(temp2.Value)
            {
                case "+":  Result = Convert.ToDouble(temp.Value) + Convert.ToDouble(txt.Text);
                           break;
                case "-":  Result = Convert.ToDouble(temp.Value) - Convert.ToDouble(txt.Text);
                           break;
                case "*":  Result = Convert.ToDouble(temp.Value) * Convert.ToDouble(txt.Text);
                           break;
                case "/":  Result = Convert.ToDouble(temp.Value) / Convert.ToDouble(txt.Text);
                           break;
            }
            
            txt.Text = Result.ToString();
        }
    }
}