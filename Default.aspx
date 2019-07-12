<%@ Page Language="C#" Inherits="RegistrationPage.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Registration Form</title>
</head>
<body>
        <h1>Register here!</h1>
        <p>Fill in your name and email address, then click <strong>Submit</strong></p>
	<form id="form1" runat="server" method="post">
            <table>
                <tr>
                    <td>Name</td>><td><asp:TextBox runat="server" id="textBoxName"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Email</td>><td><asp:TextBox runat="server" id="textBoxEmail"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Job</td>><td><asp:TextBox runat="server" id="textBoxJob"></asp:TextBox></td>
                </tr>  
                <tr>
                    <td>
                        <asp:Button id="buttonSubmit" runat="server" Text="Submit" OnClick="buttonSubmit_Click" />
                        </td>><td>
                        <asp:Button id="buttonLoadData" runat="server" Text="Load Data" OnClick="buttonLoadData_Click" />
                    </td>
                                    </tr>
            </table>
            <h2>People who are registered:</h2>
            <table width="100%">
                <tr>
                    <td>
                        <asp:GridView id="GridViewUser" runat="server" AutoGenerateColumns="true">
                        </asp:GridView>
                    </td>
                    </tr>
                </table>
	</form>
</body>
</html>
