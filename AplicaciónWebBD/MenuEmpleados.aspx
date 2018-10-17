<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MenuEmpleados.aspx.cs" Inherits="MenuEmpleados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-color: #00FFFF; height: 377px; width: 791px;">
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 459px; top: 157px; position: absolute; height: 56px; width: 165px" Text="Admin Usuarios" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 141px; top: 160px; position: absolute; height: 58px; width: 178px" Text="Altas Pagos Clientes" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 142px; top: 80px; position: absolute" Text="Escoga la opción que quiera realizar:"></asp:Label>
    
    </div>
    </form>
</body>
</html>
