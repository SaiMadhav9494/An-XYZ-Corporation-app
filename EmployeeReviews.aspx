<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EmployeeReviews.aspx.cs" Inherits="EmployeeReviews" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 70%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblSessionID" runat="server" Text="Label"></asp:Label>
        </div>
    <div>
    
        <table class="auto-style1">
            <tr>
                <td colspan="3">Employee Reviews for 2016</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Name</td>
                <td>Job Title</td>
                <td>Review</td>
            </tr>
            <tr>
                <td>Bill</td>
                <td>Programmer</td>
                <td>Needs better code organization</td>
            </tr>
            <tr>
                <td>Sally</td>
                <td>Manager</td>
                <td>Completed Project on time</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
