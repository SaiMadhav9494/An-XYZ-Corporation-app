using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Salaries : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblSessionID.Text = Session.SessionID;
        if (Session["LOGGEDIN"] == null)
            Response.Redirect("Login.aspx");
    }
}