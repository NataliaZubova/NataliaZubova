using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.IO;

namespace WebServiceSRV
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            Service1 srv = new Service1();
            string dan = System.Convert.ToString(TextBox3.Text);
            string dan2 = System.Convert.ToString(TextBox4.Text);
            srv.SRV(dan,dan2).ToString();
            
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}