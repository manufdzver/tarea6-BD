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
        <asp:Table ID="Table1" runat="server" Width="764px" Visible="False">
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
        <asp:Button ID="btEje" runat="server" style="z-index: 1; left: 719px; top: 310px; position: absolute; height: 69px; width: 79px" Text="Ejecutar" Visible="False" />
        <br />
        <asp:Button ID="btAlta" runat="server" OnClick="btAlta_Click" style="z-index: 1; left: 345px; top: 295px; position: absolute; width: 123px" Text="Alta pago" Visible="False" />
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 522px; top: 340px; position: absolute" Text="Monto:" Visible="False"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;<asp:Button ID="btBaja" runat="server" OnClick="btBaja_Click" style="z-index: 1; left: 344px; top: 325px; position: absolute; width: 124px; right: 638px" Text="Baja pago" Visible="False" />
        <asp:Button ID="btMod" runat="server" OnClick="btMod_Click" style="z-index: 1; left: 344px; top: 359px; position: absolute; width: 123px" Text="Modifica pago" Visible="False" />
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 520px; top: 271px; position: absolute; right: 735px" Text="Fecha de pago:" Visible="False"></asp:Label>
&nbsp;<asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 518px; top: 368px; position: absolute" Visible="False"></asp:TextBox>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 518px; top: 297px; position: absolute" Visible="False"></asp:TextBox>
            
    </div>
    </form>
</body>
</html>
