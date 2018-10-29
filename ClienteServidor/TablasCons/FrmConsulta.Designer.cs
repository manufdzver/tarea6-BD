namespace ClienteServidor.TablasCons {
    partial class FrmConsulta {
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dSAlumCalifs = new ClienteServidor.DSAlumCalifs();
            this.aLUMCALIFSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aLUMCALIFSTableAdapter = new ClienteServidor.DSAlumCalifsTableAdapters.ALUMCALIFSTableAdapter();
            this.nOMALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMMATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cALIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAlumCalifs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMCALIFSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nOMALDataGridViewTextBoxColumn,
            this.nOMMATDataGridViewTextBoxColumn,
            this.cALIFDataGridViewTextBoxColumn,
            this.fECHADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aLUMCALIFSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(60, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(548, 235);
            this.dataGridView1.TabIndex = 0;
            // 
            // dSAlumCalifs
            // 
            this.dSAlumCalifs.DataSetName = "DSAlumCalifs";
            this.dSAlumCalifs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aLUMCALIFSBindingSource
            // 
            this.aLUMCALIFSBindingSource.DataMember = "ALUMCALIFS";
            this.aLUMCALIFSBindingSource.DataSource = this.dSAlumCalifs;
            // 
            // aLUMCALIFSTableAdapter
            // 
            this.aLUMCALIFSTableAdapter.ClearBeforeFill = true;
            // 
            // nOMALDataGridViewTextBoxColumn
            // 
            this.nOMALDataGridViewTextBoxColumn.DataPropertyName = "NOMAL";
            this.nOMALDataGridViewTextBoxColumn.HeaderText = "NOMAL";
            this.nOMALDataGridViewTextBoxColumn.Name = "nOMALDataGridViewTextBoxColumn";
            this.nOMALDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMMATDataGridViewTextBoxColumn
            // 
            this.nOMMATDataGridViewTextBoxColumn.DataPropertyName = "NOMMAT";
            this.nOMMATDataGridViewTextBoxColumn.HeaderText = "NOMMAT";
            this.nOMMATDataGridViewTextBoxColumn.Name = "nOMMATDataGridViewTextBoxColumn";
            this.nOMMATDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cALIFDataGridViewTextBoxColumn
            // 
            this.cALIFDataGridViewTextBoxColumn.DataPropertyName = "CALIF";
            this.cALIFDataGridViewTextBoxColumn.HeaderText = "CALIF";
            this.cALIFDataGridViewTextBoxColumn.Name = "cALIFDataGridViewTextBoxColumn";
            this.cALIFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fECHADataGridViewTextBoxColumn
            // 
            this.fECHADataGridViewTextBoxColumn.DataPropertyName = "FECHA";
            this.fECHADataGridViewTextBoxColumn.HeaderText = "FECHA";
            this.fECHADataGridViewTextBoxColumn.Name = "fECHADataGridViewTextBoxColumn";
            this.fECHADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 397);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmConsulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.FrmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAlumCalifs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMCALIFSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DSAlumCalifs dSAlumCalifs;
        private System.Windows.Forms.BindingSource aLUMCALIFSBindingSource;
        private DSAlumCalifsTableAdapters.ALUMCALIFSTableAdapter aLUMCALIFSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMMATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cALIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHADataGridViewTextBoxColumn;
    }
}