﻿using System;
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

<<<<<<< HEAD
    DataSet DsClientes = new DataSet();
    DataSet DsPedidos = new DataSet();

=======
    DataSet dsClientes = new DataSet();
    
>>>>>>> b9efeb8b9d6646a8bfcee35027deb91ea4ee19e3
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

<<<<<<< HEAD

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GestorBD = (GestorBD.GestorBD)Session["GestorBD"];
        cadSql = "select FolioP from  PCPedidos p, PCClientes c, PCEmpleados e where p.RFCC = '"+
            DropDownList1.SelectedValue+"' and p.RFCC = '"+ Session["rfc"].ToString()+"'";
        GestorBD.consBD(cadSql, DsPedidos, "Pedidos");
        comunes.cargaDDL(DropDownList2, DsPedidos, "Pedidos", "FolioP");
        Session["DsPedidos"] = DsPedidos;
    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Un Table el cual se mostrará al momento de seleccionar un pedido; en él se verán: 
        //la fecha del pedido, su total a pagar, la suma acumulada de los montos de los 
        //    pagos que se han realizado para el mismo y el saldo que resta por cubrir.
        //    Si no tiene pagos, muestra un mensaje adecuado.

      GestorBD = (GestorBD.GestorBD)Session["GestorBD"];
        cadSql = "select fechaPed, sum(Monto) as sum, saldoCli, saldoFacs from  PCPedidos p, PCClientes c, PCEmpleados e where p.RFCC = '" +
            DropDownList1.SelectedValue + "' and p.RFCC = '" + Session["rfc"].ToString() + "'";
        GestorBD.consBD(cadSql, DsPedidos, "Pedidos");
        comunes.cargaDDL(DropDownList2, DsPedidos, "Pedidos", "FolioP");
=======
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label2.Visible = true;
        DropDownList2.Visible = true;
        
>>>>>>> b9efeb8b9d6646a8bfcee35027deb91ea4ee19e3
    }
}