using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AltasEmpleados : System.Web.UI.Page
{
    GestorBD.GestorBD GestorBD;
    string cadSql;
    Comunes comunes = new Comunes();

    DataSet dsClientes = new DataSet();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            string rfc = Session["rfc"].ToString();
            GestorBD = (GestorBD.GestorBD)Session["GestorBD"];

            cadSql = "select u.nombre, u.RFC from PCUsuarios u, PCClientes c, PCPedidos p where u.RFC=c.RFC and c.RFC=p.RFCC and p.RFCE='" + rfc + "'";
            GestorBD.consBD(cadSql, dsClientes, "Clientes");

            DropDownList1.Items.Add(" ");
            foreach (DataRow fila in dsClientes.Tables["Clientes"].Rows)
                DropDownList1.Items.Add(new ListItem(fila["nombre"].ToString(), fila["RFC"].ToString()));
        }
        

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label2.Visible = true;
        DropDownList2.Visible = true;
        
    }
}