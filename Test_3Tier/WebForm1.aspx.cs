using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

namespace Test_3Tier
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        TestBL testBL = new TestBL ();

        protected void Page_Load(object sender, EventArgs e)
        {
            bool test = testBL.TestMethod();

            TextBox1.Text = test.ToString();
                 
        }
    }
}