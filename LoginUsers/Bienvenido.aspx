<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bienvenido.aspx.cs" Inherits="LoginUsers.Bienvenido" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Bienvenido al Sistema</h1>
        <p>
            <asp:Label ID="lblAlumnos" runat="server" Height="25px" Text="Alumnos"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnAgregar" runat="server" Height="30px" OnClick="btnAgregar_Click" Text="Agregar" Width="86px" />
&nbsp;&nbsp;
            <asp:Button ID="btnListar" runat="server" Height="28px" style="margin-top: 0px" Text="Listar" Width="92px" OnClick="btnListar_Click" />
        </p>
    </div>
    <div>
        
        <asp:GridView ID="gridAlumnos" runat="server">
        </asp:GridView>
        
    </div>
    </form>
</body>
</html>
