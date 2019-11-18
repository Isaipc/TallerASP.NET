<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TallerASP.NET.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="js/bootstrap.min.js"></script>
    <script src="js/jquery-3.4.1.min.js"></script>

</head>
<body class="bg-dark">

    <div class="card w-25 m-auto p-5 text-dark">
        <form id="form1" runat="server">
                <div class="header">
                    <h2>
                        ITSSAT
                    </h2>
                </div>
                <div class="body ">
                    <div class="form-group">
                        <span>Email:</span>
                        <asp:TextBox ID="userBox" runat="server" TextMode="Email" CssClass="form-control" placeholder="email" required/>
                    </div>
                    <div class="form-group">   
                        <span>Pass:</span>
                        <asp:TextBox ID="passwordBox" TextMode="Password" runat="server" CssClass="form-control" placeholder="password" required/>
                    </div>
                </div>
                <div class="footer">
                    <div class="form-group">
                        <asp:Button ID="iniciarButton" Text="Iniciar sesión" runat="server" CssClass="btn btn-primary btn-block" OnClick="iniciarButton_Click"/>
                        <asp:Button ID="registrarButton" Text="Registrarse" runat="server" CssClass="btn btn-outline-dark btn-block" OnClick="registrarButton_Click"/>
                    </div>
                </div>
        </form>
    </div>
</body>
</html>
