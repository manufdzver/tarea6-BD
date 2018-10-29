using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteServidor {
    public partial class FrmMenú : Form {
        public FrmMenú() {
            InitializeComponent();
        }

        private void taToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit(); //Salir

        }

        //Abre la forma de alumnos
        private void MnuAlumnos_Click(object sender, EventArgs e) {
            TablasCons.FrmAlumnos fa = new TablasCons.FrmAlumnos();
            fa.Show();
        }

        //Abre la forma de consulta
        private void alumsCalificacionToolStripMenuItem_Click(object sender, EventArgs e) {
            TablasCons.FrmConsulta fa = new TablasCons.FrmConsulta();
            fa.ShowDialog();
        }


        private void MnuSubProgsAlum_Click(object sender, EventArgs e) {
            Procesos.FrmSubProgsAlm fsa = new Procesos.FrmSubProgsAlm();
            fsa.Show();
        }

        private void MnuGestorBD_Click(object sender, EventArgs e) {
            Procesos.FrmGestorBD fg = new Procesos.FrmGestorBD();
            fg.Show();
        }

        private void MnuOtrasBDs_Click(object sender, EventArgs e) {
            TablasCons.FrmOtrasBDs fob = new TablasCons.FrmOtrasBDs();
            fob.Show();
        }

        private void MnuTransac_Click(object sender, EventArgs e) {
            Procesos.FrmTransac ft = new Procesos.FrmTransac();
            ft.Show();
        }
    }
}
