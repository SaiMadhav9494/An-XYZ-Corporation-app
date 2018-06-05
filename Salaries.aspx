<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Salaries.aspx.cs" Inherits="Salaries" %>

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
    <form id="form2" runat="server">
    <div>
    <div>
            <asp:Label ID="lblSessionID" runat="server" Text="Label"></asp:Label>
        </div>
        <table class="auto-style1">
            <tr>
                <td colspan="3">Salaries for 2016</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Name</td>
                <td>Job Title</td>
                <td>Salary</td>
            </tr>
            <tr>
                <td>Bill</td>
                <td>Programmer</td>
                <td>65,500</td>
            </tr>
            <tr>
                <td>Sally</td>
                <td>Manager</td>
                <td>86,700</td>
            </tr>
        </table>
    
    </div>
    </form>
   
    <div>
    
    </div>
    </form>
</body>
</html>
