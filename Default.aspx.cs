using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{
    int i = 0;
    int k = 1;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (i == 0)
        {
            TextBox1.Text = "Hola Juan (¬_¬)...";
            i = 1;
        }
        else if (i == 1)
        {
            TextBox1.Text = "Ya lo viste veces=" + k + " tajaditas (u_u)";
            i = 0;
        }
    }
}
