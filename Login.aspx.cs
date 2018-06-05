using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblSessionID.Text = Session.SessionID;
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        IBusinessAuthentication iba = new BusinessAuthentication();
        if (iba.VerifyLogin(txtUsername.Text, txtPassword.Text) == true)
        { 
            lblStatus.Text = "Welcome " + txtUsername.Text;
            Session["LOGGEDIN"] = txtUsername.Text;
            Session.Timeout = 1;  // 1 minute expiration
        }
        else
        {
            lblStatus.Text = "invalid Login..";
        }
    }
}