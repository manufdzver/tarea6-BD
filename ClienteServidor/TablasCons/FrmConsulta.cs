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
    public partial class FrmConsulta : Form {
        public FrmConsulta() {
            InitializeComponent();
        }

        private void FrmConsulta_Load(object sender, EventArgs e) {
            // TODO: esta línea de código carga datos en la tabla 'dSAlumCalifs.ALUMCALIFS' Puede moverla o quitarla según sea necesario.
            this.aLUMCALIFSTableAdapter.Fill(this.dSAlumCalifs.ALUMCALIFS);

        }
    }
}
