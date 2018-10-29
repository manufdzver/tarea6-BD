namespace ClienteServidor.Procesos {
    partial class FrmGestorBD {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dtgGeneral = new System.Windows.Forms.DataGridView();
            this.cboAlumnos = new System.Windows.Forms.ComboBox();
            this.cboMaterias = new System.Windows.Forms.ComboBox();
            this.btnAltaCalif = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCalif = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnBajaCalif = new System.Windows.Forms.Button();
            this.btnCambiaCalif = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgGeneral
            // 
            this.dtgGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGeneral.Location = new System.Drawing.Point(30, 43);
            this.dtgGeneral.Name = "dtgGeneral";
            this.dtgGeneral.Size = new System.Drawing.Size(530, 204);
            this.dtgGeneral.TabIndex = 0;
            this.dtgGeneral.Click += new System.EventHandler(this.dtgGeneral_Click);
            // 
            // cboAlumnos
            // 
            this.cboAlumnos.AccessibleName = "";
            this.cboAlumnos.FormattingEnabled = true;
            this.cboAlumnos.Location = new System.Drawing.Point(30, 265);
            this.cboAlumnos.Name = "cboAlumnos";
            this.cboAlumnos.Size = new System.Drawing.Size(121, 21);
            this.cboAlumnos.TabIndex = 1;
            this.cboAlumnos.Text = "Alumnos";
            this.cboAlumnos.SelectedIndexChanged += new System.EventHandler(this.cboAlumnos_SelectedIndexChanged);
            // 
            // cboMaterias
            // 
            this.cboMaterias.FormattingEnabled = true;
            this.cboMaterias.Location = new System.Drawing.Point(30, 307);
            this.cboMaterias.Name = "cboMaterias";
            this.cboMaterias.Size = new System.Drawing.Size(121, 21);
            this.cboMaterias.TabIndex = 2;
            this.cboMaterias.Text = "Materias";
            this.cboMaterias.Visible = false;
            // 
            // btnAltaCalif
            // 
            this.btnAltaCalif.Location = new System.Drawing.Point(345, 309);
            this.btnAltaCalif.Name = "btnAltaCalif";
            this.btnAltaCalif.Size = new System.Drawing.Size(117, 23);
            this.btnAltaCalif.TabIndex = 3;
            this.btnAltaCalif.Text = "Alta Calificación";
            this.btnAltaCalif.UseVisualStyleBackColor = true;
            this.btnAltaCalif.Click += new System.EventHandler(this.btnAltaCalif_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selecciona la calificación:";
            this.label1.Visible = false;
            // 
            // cboCalif
            // 
            this.cboCalif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCalif.FormattingEnabled = true;
            this.cboCalif.Items.AddRange(new object[] {
            "10",
            "9",
            "8",
            "7",
            "6",
            "5"});
            this.cboCalif.Location = new System.Drawing.Point(181, 307);
            this.cboCalif.Name = "cboCalif";
            this.cboCalif.Size = new System.Drawing.Size(121, 21);
            this.cboCalif.TabIndex = 5;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(181, 349);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(121, 20);
            this.dtpFecha.TabIndex = 6;
            this.dtpFecha.Visible = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(345, 346);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(117, 23);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar Alta";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Visible = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnBajaCalif
            // 
            this.btnBajaCalif.Location = new System.Drawing.Point(506, 310);
            this.btnBajaCalif.Name = "btnBajaCalif";
            this.btnBajaCalif.Size = new System.Drawing.Size(99, 22);
            this.btnBajaCalif.TabIndex = 8;
            this.btnBajaCalif.Text = "Baja de Calif";
            this.btnBajaCalif.UseVisualStyleBackColor = true;
            this.btnBajaCalif.Click += new System.EventHandler(this.btnBajaCalif_Click);
            // 
            // btnCambiaCalif
            // 
            this.btnCambiaCalif.Location = new System.Drawing.Point(506, 345);
            this.btnCambiaCalif.Name = "btnCambiaCalif";
            this.btnCambiaCalif.Size = new System.Drawing.Size(99, 24);
            this.btnCambiaCalif.TabIndex = 9;
            this.btnCambiaCalif.Text = "Cambio de Calif";
            this.btnCambiaCalif.UseVisualStyleBackColor = true;
            // 
            // FrmGestorBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 434);
            this.Controls.Add(this.btnCambiaCalif);
            this.Controls.Add(this.btnBajaCalif);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cboCalif);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAltaCalif);
            this.Controls.Add(this.cboMaterias);
            this.Controls.Add(this.cboAlumnos);
            this.Controls.Add(this.dtgGeneral);
            this.Name = "FrmGestorBD";
            this.Text = "Proceso de la Base de Datos con una Bilioteca DLL";
            this.Load += new System.EventHandler(this.FrmGestorBD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgGeneral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgGeneral;
        private System.Windows.Forms.ComboBox cboAlumnos;
        private System.Windows.Forms.ComboBox cboMaterias;
        private System.Windows.Forms.Button btnAltaCalif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCalif;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnBajaCalif;
        private System.Windows.Forms.Button btnCambiaCalif;
    }
}