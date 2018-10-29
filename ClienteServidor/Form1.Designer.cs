namespace ClienteServidor {
    partial class FrmMenú {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAlumnos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOtrasBDs = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSubProgsAlum = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuGestorBD = new System.Windows.Forms.ToolStripMenuItem();
            this.tabuladorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTransac = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.tablasToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.tabuladorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(817, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taToolStripMenuItem});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // taToolStripMenuItem
            // 
            this.taToolStripMenuItem.Name = "taToolStripMenuItem";
            this.taToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.taToolStripMenuItem.Text = "Salir";
            this.taToolStripMenuItem.Click += new System.EventHandler(this.taToolStripMenuItem_Click);
            // 
            // tablasToolStripMenuItem
            // 
            this.tablasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAlumnos,
            this.mnuConsulta,
            this.MnuOtrasBDs});
            this.tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
            this.tablasToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.tablasToolStripMenuItem.Text = "Tablas";
            // 
            // MnuAlumnos
            // 
            this.MnuAlumnos.Name = "MnuAlumnos";
            this.MnuAlumnos.Size = new System.Drawing.Size(122, 22);
            this.MnuAlumnos.Text = "Alumnos";
            this.MnuAlumnos.Click += new System.EventHandler(this.MnuAlumnos_Click);
            // 
            // mnuConsulta
            // 
            this.mnuConsulta.Name = "mnuConsulta";
            this.mnuConsulta.Size = new System.Drawing.Size(122, 22);
            this.mnuConsulta.Text = "Consulta";
            this.mnuConsulta.Click += new System.EventHandler(this.alumsCalificacionToolStripMenuItem_Click);
            // 
            // MnuOtrasBDs
            // 
            this.MnuOtrasBDs.Name = "MnuOtrasBDs";
            this.MnuOtrasBDs.Size = new System.Drawing.Size(122, 22);
            this.MnuOtrasBDs.Text = "OtrasBDs";
            this.MnuOtrasBDs.Click += new System.EventHandler(this.MnuOtrasBDs_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuSubProgsAlum,
            this.MnuGestorBD,
            this.MnuTransac});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // MnuSubProgsAlum
            // 
            this.MnuSubProgsAlum.Name = "MnuSubProgsAlum";
            this.MnuSubProgsAlum.Size = new System.Drawing.Size(152, 22);
            this.MnuSubProgsAlum.Text = "Subprogs Alm";
            this.MnuSubProgsAlum.Click += new System.EventHandler(this.MnuSubProgsAlum_Click);
            // 
            // MnuGestorBD
            // 
            this.MnuGestorBD.Name = "MnuGestorBD";
            this.MnuGestorBD.Size = new System.Drawing.Size(152, 22);
            this.MnuGestorBD.Text = "Gestor BD";
            this.MnuGestorBD.Click += new System.EventHandler(this.MnuGestorBD_Click);
            // 
            // tabuladorToolStripMenuItem
            // 
            this.tabuladorToolStripMenuItem.Name = "tabuladorToolStripMenuItem";
            this.tabuladorToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.tabuladorToolStripMenuItem.Text = "Tabulador";
            // 
            // MnuTransac
            // 
            this.MnuTransac.Name = "MnuTransac";
            this.MnuTransac.Size = new System.Drawing.Size(152, 22);
            this.MnuTransac.Text = "Transacciones";
            this.MnuTransac.Click += new System.EventHandler(this.MnuTransac_Click);
            // 
            // FrmMenú
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClienteServidor.Properties.Resources.Fortnite_3_2_810x400;
            this.ClientSize = new System.Drawing.Size(817, 360);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenú";
            this.Text = "Menú Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabuladorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuAlumnos;
        private System.Windows.Forms.ToolStripMenuItem mnuConsulta;
        private System.Windows.Forms.ToolStripMenuItem MnuSubProgsAlum;
        private System.Windows.Forms.ToolStripMenuItem MnuGestorBD;
        private System.Windows.Forms.ToolStripMenuItem MnuOtrasBDs;
        private System.Windows.Forms.ToolStripMenuItem MnuTransac;
    }
}

