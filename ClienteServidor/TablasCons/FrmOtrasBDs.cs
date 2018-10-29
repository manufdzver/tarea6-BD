using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteServidor.TablasCons {
  public partial class FrmOtrasBDs : Form {
    public FrmOtrasBDs() {
      InitializeComponent();
    }

    //Atributos de la clase.
    private GestorBD.GestorBD GestorBDAcc;
    private GestorBD.GestorBD GestorBDSQL;
    private DataSet dsMater = new DataSet();
    private DataSet dsAlum = new DataSet();
    private String cadSql;

    //Muestra los datos de las materias utilizando sólo el GestorBD.
    private void FrmMaterGestor_Load(object sender, EventArgs e) {

    }

    //Ejemplo de conexión a Access.
    private void button1_Click(object sender, EventArgs e) {

      //1- Crea el objeto para acceder a la base de datos.
      GestorBDAcc = new GestorBD.GestorBD("Microsoft.ACE.OLEDB.12.0", "Admin", "",
                    "C:/BD/Desarrollos/BDs/SistEsc1o.accdb");

      //2- Obtiene datos de las materias.
      cadSql = "select * from Mater";                         //Consulta.
      GestorBDAcc.consBD(cadSql, dsMater, "Mater");           //Se ejecuta.
      dtgGeneral.DataSource = dsMater.Tables["Mater"];        //Muestra resultados.
    }

    //Ejemplo de conexión a SQL Server.
    private void button2_Click(object sender, EventArgs e) {
      //1- Crea el objeto para acceder a la base de datos.
      GestorBDSQL = new GestorBD.GestorBD("SQLNCLI11", "localhost",
                    "sa", "sqladmin", "SistemaEscolar");

      //2- Obtiene datos de los alumnos.
      cadSql = "select * from Alum";                         //Consulta.
      GestorBDSQL.consBD(cadSql, dsAlum, "Alum");           //Se ejecuta.
      dtgGeneral.DataSource = dsAlum.Tables["Alum"];        //Muestra resultados.
    }
  }

}
