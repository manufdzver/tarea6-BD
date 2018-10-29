using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteServidor.Procesos {
  public partial class FrmTransac : Form {
    public FrmTransac() {
      InitializeComponent();
    }

    //Variables generales de módulo.
    DataSet dsGeneral= new DataSet(); String cons;
    const int OK= 1;
    GestorBD.GestorBD GestorBD;      //Para manejar la BD.

    //Para manejar el objeto de la transacción.
    OleDbTransaction t;

    //Acciones iniciales.
    private void FrmTransac_Load(object sender, EventArgs e) {

      //Para distinguir las instancias de ejecución de esta forma.
      this.Text= this.Text + " " + DateTime.Now.Millisecond;

      //Permite el acceso a la BD.
      GestorBD = new GestorBD.GestorBD("MSDAORA", "bd07", "fercab", "oracle");

      //Obtiene datos de las materias.
      cons = "select * from Mater";                       //Consulta.
      GestorBD.consBD(cons, dsGeneral, "Mater");          //Se ejecuta.
      DtgGeneral.DataSource = dsGeneral.Tables["Mater"];     //Muestra resultados.
    }

    //Inicia transacción tipo Read Committed.
    private void BtnTranReadCom_Click(object sender, EventArgs e) {
      try {
        GestorBD.conex.Open();         //Se conecta a la BD.

        //Se crea el objeto de transacción y se especifica el nivel de aislamiento.
        t = GestorBD.conex.BeginTransaction(IsolationLevel.ReadCommitted);
        Label1.Text = "Read Commited";
      }
      catch (OleDbException err) {
        MessageBox.Show(err.Message);
      }
    }

    //Inicia transacción tipo Serializable.
    private void BtnTranSerial_Click(object sender, EventArgs e) {
      try {
        GestorBD.conex.Open();         //Se conecta a la BD.

        //Se crea el objeto de transacción y se especifica el nivel de aislamiento.
        t = GestorBD.conex.BeginTransaction(IsolationLevel.Serializable);
        Label1.Text = "Serializable";
      }
      catch (OleDbException err) {
        MessageBox.Show(err.Message);
      }
    }

    //Acciones finales al concluir la transacción.
    private void BtnFinTran_Click(object sender, EventArgs e) {
      try {
        t.Commit();        //Confirma la transacción.
      }
      catch (OleDbException err) {
        MessageBox.Show(err.Message);
        t.Rollback();      //Si hay error, revierte la transacción.
      }
      GestorBD.conex.Close();      //Cierra la conexión a la BD.
      t = null;                       //Destruye el objeto de transacción.
      Label1.Text = ""; MessageBox.Show("Terminé la transacción");
    }

    //Consulta normal ejecutada fuera de una transacción.
    private void BtnSelect_Click(object sender, EventArgs e) {
      cons = "select * from Mater";
      GestorBD.consBD(cons, dsGeneral, "Mater");         //Se ejecuta.
    }

    //Consulta ejecutada dentro de una transacción.
    private void BtnSelectTran_Click(object sender, EventArgs e) {
      cons = "select * from Mater";
      GestorBD.consBD(t, cons, "Mater", dsGeneral);    //Se ejecuta.
    }

    //Select for update: bloquea las tuplas que cumplen la condición.
    private void BtnSelectUpdate_Click(object sender, EventArgs e) {
      cons = "select * from Mater for update";
      GestorBD.consBD(t, cons, "Mater", dsGeneral);   //Se ejecuta.
    }

    //Inserción normal de una tupla.
    private void BtnInsert_Click(object sender, EventArgs e) {
      int i; String cadSql ;

      try { 
        i = DateTime.Now.Millisecond;
        cadSql = "insert into Mater values (" + (1000+i) + ",'Bases de Datos 1" + i + "',8)";

        //Envía la nueva inserción.
        if (GestorBD.altaBD(cadSql) == OK)
          MessageBox.Show("Se hizo la inserción exitosamente");
        else
          MessageBox.Show("No se pudo insertar la nueva tupla");
      }
      catch (OleDbException err) {
        MessageBox.Show(err.Message);
      }
    }

    //Inserción de una tupla dentro de una transacción.
    private void BtnInsertTran_Click(object sender, EventArgs e) {
      int i; String cadSql;

      try {
        i = DateTime.Now.Millisecond;
        cadSql = "insert into Mater values (" + (1000+i) + ",'Bases de Datos 1" + i + "',8)";

        //Envía la nueva inserción.
        if (GestorBD.altaBD(t, cadSql) == OK)
          MessageBox.Show("Se hizo la inserción exitosamente");
        else
          MessageBox.Show("No se pudo insertar la nueva tupla");
      }
      catch (OleDbException err) {
        MessageBox.Show(err.Message);
      }
    }

    //Cambio de una tupla dentro de una transacción.
    private void BtnUpdateTran_Click(object sender, EventArgs e) {
      String cadSql;

      try {
        cadSql = "update Mater set Creds= Creds+1 where ClaveM= 800";

        //Envía el cambio.
        if (GestorBD.cambiaBD(t, cadSql) == OK)
          MessageBox.Show("Se hizo el cambió exitosamente");
        else
          MessageBox.Show("No se pudo hacer el cambio");
      }
      catch (OleDbException err) {
        MessageBox.Show(err.Message);
      }
    }

    //Al dar clic al botón, borra en la tabla de materias la que fue seleccionada en el grid.
    private void BtnBorrar_Click(object sender, EventArgs e) {
      int clave; String cadSql;

      clave = Convert.ToInt16(DtgGeneral.CurrentCell.Value);
      try {
        cadSql = "delete from Mater where ClaveM=" + clave;
        //Borra la materia.
        if (GestorBD.bajaBD(cadSql) == OK)
          MessageBox.Show("Se borró la materia exitosamente");
        else
          MessageBox.Show("No se pudo borrar la materia");
      }
      catch (OleDbException err) {
        MessageBox.Show(err.Message);
      }
    }

    
  }
}
