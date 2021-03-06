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

    DataSet DsClientes = new DataSet();
    DataSet DsPedidos = new DataSet();
    DataSet DsPagos = new DataSet();
    DataSet DsPagos2 = new DataSet();
    DataSet DsPagos3 = new DataSet();
    DataRow Fila;
    
     

  protected void Page_Load(object sender, EventArgs e)
  {

      if(!IsPostBack)
      {
            Session["op"] = "";
            string rfc = Session["rfc"].ToString();
          GestorBD = (GestorBD.GestorBD)Session["GestorBD"];

          cadSql = "select u.nombre, u.RFC from PCUsuarios u, PCClientes c, PCPedidos p where u.RFC=c.RFC and c.RFC=p.RFCC and p.RFCE='" + rfc + "'";
          GestorBD.consBD(cadSql, DsClientes, "Clientes");

          DropDownList1.Items.Add(" ");
          foreach (DataRow fila in DsClientes.Tables["Clientes"].Rows)
              DropDownList1.Items.Add(new ListItem(fila["nombre"].ToString(), fila["RFC"].ToString()));
          
      }

        

  }


  protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
  {
        //Primero restablecemos todos los valores y cajas

        Label3.Visible = false;
        Label4.Visible = false;
        TextBox1.Visible = false;
        TextBox2.Visible = false;
        btEje.Visible = false;
        ddlPago.Visible = false;
        Table1.Visible = false;
        GridView1.Visible = false;
        Label5.Visible = false;
        TextBox1.Text = "";
        TextBox2.Text = "";
        btAlta.Visible = false;
        btBaja.Visible = false;
        btMod.Visible = false;

        Label2.Visible = true;
      DropDownList2.Visible = true;
      GestorBD = (GestorBD.GestorBD)Session["GestorBD"];
      cadSql = "select distinct p.FolioP from  PCPedidos p, PCClientes c, PCEmpleados e where p.RFCC = '"+
          DropDownList1.SelectedValue+"' and p.RFCE = '"+ Session["rfc"].ToString()+"'";
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
      Table1.Visible = true;
        btAlta.Visible = true;
        btBaja.Visible = true;
        btMod.Visible = true;
        GridView1.Visible = true;
        GestorBD = (GestorBD.GestorBD)Session["GestorBD"];
      cadSql = "select fechaPed, pe.monto, sum(distinct(pa.monto)) as saldo, pe.monto-sum(distinct(pa.monto)) as deuda " +
            "from PCPagos pa, PCPedidos pe, PCClientes c, PCEmpleados e where pe.RFCC = '"+
            DropDownList1.SelectedValue+"' and pe.RFCE = '"+ Session["rfc"].ToString()+
            "' and pe.foliop=pa.folioP and pe.folioP='"+DropDownList2.SelectedValue+"' "+
            "group by fechaPed, pe.monto";
      GestorBD.consBD(cadSql, DsPagos, "Pedidos");
        //Despliega los datos en la tabla.

        if (DsPagos.Tables["Pedidos"].Rows.Count > 0) {
            Fila = DsPagos.Tables["Pedidos"].Rows[0];
            Table1.Rows[1].Cells[0].Text = Fila["FechaPed"].ToString();
            Table1.Rows[1].Cells[1].Text = Fila["monto"].ToString();
            Table1.Rows[1].Cells[2].Text = Fila["saldo"].ToString();
            Table1.Rows[1].Cells[3].Text = Fila["deuda"].ToString();
        }
        else {
            Response.Write("Error, el cliente no ha hecho ningun pago");
            
        }

        //Un GridView, que también se mostrará al momento de seleccionar un pedido, 
        //con los datos de cada pago realizado por el cliente para ese pedido: 
        //clave, fecha y monto del pago (posiblemente aquí puedas reutilizar código).
        cadSql = "select distinct f.idPago, f.fecha, f.monto from PCPagos f, PCPedidos p where " +
            "f.FolioP = '" + DropDownList2.SelectedValue + "' order by f.idPago asc";
        GestorBD.consBD(cadSql, DsPagos2, "Pagos2");
        GridView1.DataSource = DsPagos2.Tables["Pagos2"];  //Muestra resultados.
        GridView1.DataBind();

    comunes.cargaDDL(ddlPago, DsPagos2, "Pagos2", "idPago");
        //Muestra los pagos realizados para el pedido seleccionado.
        //cadSql = "select * from PCPagos where FolioP=" + DDLPedidos.Text;
        //GestorBD.consBD(cadSql, DsPagos, "Pagos");
        //GrdPagos.DataSource = DsPagos.Tables["Pagos"];  //Muestra resultados.
        //GrdPagos.DataBind();
    }


    protected void btAlta_Click(object sender, EventArgs e)
    {
        Session["op"] = "alta";
        Label3.Visible = true;
        Label4.Visible = true;
        TextBox1.Visible = true;
        TextBox2.Visible = true;
        btEje.Visible = true;
    ddlPago.Visible = false;
    Label5.Visible = false;
        TextBox1.Text = "" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;

    }

    protected void btBaja_Click(object sender, EventArgs e)
    {
        Session["op"] = "baja";
        Label3.Visible = false;
        Label4.Visible = false;
        TextBox1.Visible = false;
        TextBox2.Visible = false;
        btEje.Visible = true;
    ddlPago.Visible = true;
    Label5.Visible = true;
  }

    protected void btMod_Click(object sender, EventArgs e)
    {
        Session["op"] = "modifica";
    Label3.Visible = true;
        Label4.Visible = true;
        TextBox1.Visible = true;
        TextBox2.Visible = true;
        btEje.Visible = true;
    ddlPago.Visible = true;
    Label5.Visible = true;
    }




    protected void btEje_Click(object sender, EventArgs e)
    {
        GestorBD = (GestorBD.GestorBD)Session["GestorBD"];
        cadSql = "select distinct f.idPago, f.fecha, f.monto from PCPagos f, PCPedidos p where " +
            "f.FolioP = '" + DropDownList2.SelectedValue + "' order by f.idPago asc";
        GestorBD.consBD(cadSql, DsPagos3, "Pagos3");
        switch (Session["op"].ToString())
        {
            case "alta":
                int num = DsPagos3.Tables["Pagos3"].Rows.Count + 1;

                cadSql = "insert into PCPagos VALUES (" + DropDownList2.SelectedValue.ToString() + ", " + num + ", date'" + TextBox1.Text + "', " + TextBox2.Text + ")";

                GestorBD.altaBD(cadSql);
                Label3.Visible = false;
                Label4.Visible = false;
                TextBox1.Visible = false;
                TextBox2.Visible = false;
                btEje.Visible = false;
                ddlPago.Visible = false;
                Label5.Visible = false;
                TextBox1.Text = "";
                TextBox2.Text = "";
                break;
            case "baja":
                cadSql = "delete from PCPagos where FolioP=" + DropDownList2.SelectedValue.ToString() + " and IdPago= "+ddlPago.Text + "";
                GestorBD.altaBD(cadSql);
                DropDownList2.SelectedIndex = 0;
                ddlPago.Visible = false;

                break;
            case "modifica":
                cadSql = "update PCPagos set fecha = date'" + TextBox1.Text + "', monto=" + TextBox2.Text + " where folioP = "+ DropDownList2.SelectedValue.ToString() + " and idPago = " + ddlPago.SelectedValue.ToString();
                GestorBD.cambiaBD(cadSql);
                Label3.Visible = false;
                Label4.Visible = false;
                TextBox1.Visible = false;
                TextBox2.Visible = false;
                btEje.Visible = false;
                ddlPago.Visible = false;
                Label5.Visible = true;
                TextBox1.Text = "";
                TextBox2.Text = "";
                break;
        }


    }
}