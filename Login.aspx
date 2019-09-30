<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TallerASP.NET.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/css/bootstrap.min.css" rel="stylesheet" />
    <%--<link href="Content/css/adminlte.min.css" rel="stylesheet" />--%>
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
                        <span>Usuario:</span>
                        <asp:TextBox ID="userBox" runat="server" CssClass="form-control" placeholder="usuario"/>
                    </div>
                    <div class="form-group">   
                        <span>Pass:</span>
                        <asp:TextBox ID="passwordBox" runat="server" CssClass="form-control" placeholder="password"/>
                    </div>
                </div>
                <div class="footer">
                    <div class="form-group">
                        <asp:Button Text="Iniciar sesión" runat="server" CssClass="btn btn-primary btn-block"/>
                        <asp:Button Text="Registrarse" runat="server" CssClass="btn btn-outline-dark btn-block"/>
                    </div>
                </div>
        </form>
    </div>
</body>
</html>
