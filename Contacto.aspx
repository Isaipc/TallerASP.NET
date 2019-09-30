<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contacto.aspx.cs" Inherits="TallerASP.NET.Contacto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Contactanos</title>

    <link href="Content/css/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/Styles.css" rel="stylesheet" />

    <script src="Scripts/jquery-3.4.1.min.js"></script>
    <script src="Scripts/js/bootstrap.min.js"></script>

</head>
<body class="bg-dark">

    <div class="container">
        <div class="form-box">
        <h2>Contacto</h2>
            <form id="form1" runat="server">
                <div class="form-group">
                    <asp:TextBox ID="nombreBox" runat="server" CssClass="form-control" required placeholder="Nombre de contacto"/>
                </div>
                <div class="form-group">
                    <asp:TextBox ID="correoBox" runat="server" CssClass="form-control" required TextMode="Email" placeholder="Correo electrónico"/>
                </div>
                <div class="form-group">
                    <asp:TextBox ID="comentarioBox" runat="server" CssClass="form-control" required TextMode="MultiLine" Rows="5" placeholder="Comentarios"/>
                </div>
                <div class="form-group">
                    <asp:Button ID="EnviarButton" Text="Enviar" runat="server" CssClass="btn btn-success btn-block" OnClick="EnviarButton_Click"/>
                </div>
            </form>
        </div>
    </div>
</body>
</html>
