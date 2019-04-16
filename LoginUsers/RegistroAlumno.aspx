<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroAlumno.aspx.cs" Inherits="LoginUsers.RegistroAlumno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Formulario de registracion de Alumnos</h1>
        <p>
            <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblApellido" runat="server" Text="Apellido:"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
        </p>
        <p>&nbsp;
            <asp:Label ID="lblDni" runat="server" Text="Dni:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDni" runat="server"></asp:TextBox>
        </p>
        <p>&nbsp;<asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </p>
        <p>&nbsp;<asp:Label ID="lblDomicilio" runat="server" Text="Domicilio:"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtDomicilio" runat="server"></asp:TextBox>
        </p>
        <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnGuardar" runat="server" Height="33px" OnClick="btnGuardar_Click" Text="Guardar" Width="96px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</p>
    </div>
    </form>
</body>
</html>
