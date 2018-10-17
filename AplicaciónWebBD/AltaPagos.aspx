<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AltaPagos.aspx.cs" Inherits="AltasEmpleados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
    <div style="background-color: #C0C0C0; height: 439px;">
    
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 65px; top: 38px; position: absolute" Text="Clientes"></asp:Label>


        <asp:DropDownList ID="DropDownList1" runat="server" style="z-index: 1; left: 194px; top: 35px; position: absolute; height: 16px; width: 166px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">

        </asp:DropDownList>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 67px; top: 94px; position: absolute" Text="Claves Pedidos" Visible="False"></asp:Label>
    
        <asp:DropDownList ID="DropDownList2" runat="server" style="z-index: 1; left: 192px; top: 90px; position: absolute; height: 14px; width: 169px" Visible="False" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
        </asp:DropDownList>
    
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Table ID="Table1" runat="server" Width="764px">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">Fecha</asp:TableCell>
                <asp:TableCell runat="server">Suma monto</asp:TableCell>
                <asp:TableCell runat="server">Pagos realizados</asp:TableCell>
                <asp:TableCell runat="server">Pagos por cubrir</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    
        <br />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
            
    </div>
    </form>
</body>
</html>
