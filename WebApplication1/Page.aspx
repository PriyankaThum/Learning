<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page.aspx.cs" Inherits="WebApplication1.Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type ="text/javascript">
        function Person() {
            var input = document.getElementById("tb").value;
            var json = JSON.parse(input);
            window.alert("Ismember : " + json['Ismember'] + "Name : " + json['Name'] + "Age : " + json['Age']);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        Enter Json Text Here :
                    </td>
                    <td>
                        <asp:TextBox ID="tb" runat="server"></asp:TextBox>
                    </td>
                </tr>
                </table>
        </div>
        <asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClientClick ="Person()" />
        <p id ="demo"></p>
    </form>
</body>
</html>
