using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page {

    //Variables de clase.
    GestorBD.GestorBD GestorBD;
    DataSet DsGeneral = new DataSet();
    DataSet DsEmpleado = new DataSet();
    string cadSql;
    string cadSql2;

        //Acciones iniciales.
    protected void Page_Load(object sender, EventArgs e) {
    Label1.Text = DateTime.Now.ToString();

    //La propiedad, de la página, IsPostBack da False la 1a. vez que se carga la págiona.
    //Después siempre da True.
    if (!IsPostBack) {
      GestorBD = new GestorBD.GestorBD("MSDAORA", "bdalumno", "estudia", "oracle");
      Session["GestorBD"] = GestorBD;
    }
  }

  //Verifica que el usuario exista.
  protected void Login1_Authenticate(object sender, AuthenticateEventArgs e) {

        GestorBD = (GestorBD.GestorBD)Session["GestorBD"];  //Recupera la conexión a la BD.

        cadSql = "select * from PCUsuarios where RFC='" + Login1.UserName +
         "' and Passw='" + Login1.Password + "'";
        GestorBD.consBD(cadSql, DsGeneral, "Usuario");

        cadSql2 = "select * from PCEmpleados where RFC='" + Login1.UserName +
          "' and Categoría != 'Gerente'";

        GestorBD.consBD(cadSql2, DsEmpleado, "Empleado");

        //Verifica si el usuario existe en la BD.
        if (DsGeneral.Tables["Usuario"].Rows.Count != 0) {
            Session["rfc"] = Login1.UserName;     //Sí, guarda el RFC del usuario.

            cadSql2 = "select * from PCEmpleados where RFC='" + Session["rfc"].ToString() +
                "' and Categoría != 'Gerente'";

            GestorBD.consBD(cadSql2, DsEmpleado, "Empleado");

            if (DsEmpleado.Tables["Empleado"].Rows.Count != 0)
            {
                Server.Transfer("MenuEmpleados.aspx");
            }
            else
            {
                Server.Transfer("AdminUsuarios.aspx");
            }
            
        }
  }
}