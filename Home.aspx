<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <asp:Label ID="lblSessionID" runat="server" Text="Label"></asp:Label>
        </div>
         <h2>Welcome to XYZ Corporation.</h2>
           <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Home.aspx">Home</asp:HyperLink><br />
           <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/News.aspx">News</asp:HyperLink><br />
              <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Salaries.aspx">Salaries</asp:HyperLink><br />
               <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/EmployeeReviews.aspx">Employee Reviews</asp:HyperLink><br />
               <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/Login.aspx">Login</asp:HyperLink><br />
                       <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/Logout.aspx">Logout</asp:HyperLink><br />

        <br />
    </div>
    </form>
</body>
</html>
