<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="master.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>login</title>
    <link href="hojaestilos.css" rel="stylesheet" />
    <script src="controlador.js"></script>

</head>
<body>
   
    
    <form runat="server">
    <h1>Master Events Manager </h1>
    <h2> Formulario de Login </h2>
    <asp:Label runat="server" for="usuario" Text="Nombre usuario"></asp:Label>
    <asp:TextBox runat="server"   id="user"> </asp:TextBox>
    <asp:Label runat="server" for="usuario" Text="Contraseña"></asp:Label>
    <asp:TextBox runat="server" TextMode="password"  id="pass"> </asp:TextBox>
    <asp:Button runat="server"   ID="iniciar" Text="Iniciar" OnClick="iniciar_Click" > </asp:Button>
    <asp:Button runat="server"   ID="registrar" Text="registrar"  > </asp:Button>
       






    </form>
</body>
</html>
