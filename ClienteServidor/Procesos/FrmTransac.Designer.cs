namespace ClienteServidor.Procesos {
  partial class FrmTransac {
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
      this.Label1 = new System.Windows.Forms.Label();
      this.BtnInsertTran = new System.Windows.Forms.Button();
      this.BtnSelectTran = new System.Windows.Forms.Button();
      this.BtnUpdateTran = new System.Windows.Forms.Button();
      this.BtnInsert = new System.Windows.Forms.Button();
      this.BtnSelectUpdate = new System.Windows.Forms.Button();
      this.BtnSelect = new System.Windows.Forms.Button();
      this.BtnFinTran = new System.Windows.Forms.Button();
      this.BtnTranSerial = new System.Windows.Forms.Button();
      this.BtnTranReadCom = new System.Windows.Forms.Button();
      this.DtgGeneral = new System.Windows.Forms.DataGridView();
      this.BtnBorrar = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.DtgGeneral)).BeginInit();
      this.SuspendLayout();
      // 
      // Label1
      // 
      this.Label1.AutoSize = true;
      this.Label1.Location = new System.Drawing.Point(23, 9);
      this.Label1.Name = "Label1";
      this.Label1.Size = new System.Drawing.Size(43, 13);
      this.Label1.TabIndex = 21;
      this.Label1.Text = "Estado:";
      // 
      // BtnInsertTran
      // 
      this.BtnInsertTran.Location = new System.Drawing.Point(281, 439);
      this.BtnInsertTran.Name = "BtnInsertTran";
      this.BtnInsertTran.Size = new System.Drawing.Size(149, 32);
      this.BtnInsertTran.TabIndex = 20;
      this.BtnInsertTran.Text = "Insert dentro de tran.";
      this.BtnInsertTran.UseVisualStyleBackColor = true;
      this.BtnInsertTran.Click += new System.EventHandler(this.BtnInsertTran_Click);
      // 
      // BtnSelectTran
      // 
      this.BtnSelectTran.Location = new System.Drawing.Point(278, 366);
      this.BtnSelectTran.Name = "BtnSelectTran";
      this.BtnSelectTran.Size = new System.Drawing.Size(153, 35);
      this.BtnSelectTran.TabIndex = 19;
      this.BtnSelectTran.Text = "Select dentro de tran.";
      this.BtnSelectTran.UseVisualStyleBackColor = true;
      this.BtnSelectTran.Click += new System.EventHandler(this.BtnSelectTran_Click);
      // 
      // BtnUpdateTran
      // 
      this.BtnUpdateTran.Location = new System.Drawing.Point(525, 438);
      this.BtnUpdateTran.Name = "BtnUpdateTran";
      this.BtnUpdateTran.Size = new System.Drawing.Size(153, 35);
      this.BtnUpdateTran.TabIndex = 18;
      this.BtnUpdateTran.Text = "Update dentro de tran.";
      this.BtnUpdateTran.UseVisualStyleBackColor = true;
      this.BtnUpdateTran.Click += new System.EventHandler(this.BtnUpdateTran_Click);
      // 
      // BtnInsert
      // 
      this.BtnInsert.Location = new System.Drawing.Point(24, 402);
      this.BtnInsert.Name = "BtnInsert";
      this.BtnInsert.Size = new System.Drawing.Size(153, 35);
      this.BtnInsert.TabIndex = 17;
      this.BtnInsert.Text = "Insert normal";
      this.BtnInsert.UseVisualStyleBackColor = true;
      this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
      // 
      // BtnSelectUpdate
      // 
      this.BtnSelectUpdate.Location = new System.Drawing.Point(525, 366);
      this.BtnSelectUpdate.Name = "BtnSelectUpdate";
      this.BtnSelectUpdate.Size = new System.Drawing.Size(153, 35);
      this.BtnSelectUpdate.TabIndex = 16;
      this.BtnSelectUpdate.Text = "Select for update";
      this.BtnSelectUpdate.UseVisualStyleBackColor = true;
      this.BtnSelectUpdate.Click += new System.EventHandler(this.BtnSelectUpdate_Click);
      // 
      // BtnSelect
      // 
      this.BtnSelect.Location = new System.Drawing.Point(24, 350);
      this.BtnSelect.Name = "BtnSelect";
      this.BtnSelect.Size = new System.Drawing.Size(153, 35);
      this.BtnSelect.TabIndex = 15;
      this.BtnSelect.Text = "Select normal";
      this.BtnSelect.UseVisualStyleBackColor = true;
      this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
      // 
      // BtnFinTran
      // 
      this.BtnFinTran.Location = new System.Drawing.Point(525, 300);
      this.BtnFinTran.Name = "BtnFinTran";
      this.BtnFinTran.Size = new System.Drawing.Size(153, 35);
      this.BtnFinTran.TabIndex = 14;
      this.BtnFinTran.Text = "Fin transacción";
      this.BtnFinTran.UseVisualStyleBackColor = true;
      this.BtnFinTran.Click += new System.EventHandler(this.BtnFinTran_Click);
      // 
      // BtnTranSerial
      // 
      this.BtnTranSerial.Location = new System.Drawing.Point(277, 300);
      this.BtnTranSerial.Name = "BtnTranSerial";
      this.BtnTranSerial.Size = new System.Drawing.Size(153, 35);
      this.BtnTranSerial.TabIndex = 13;
      this.BtnTranSerial.Text = "Tran. Serializable";
      this.BtnTranSerial.UseVisualStyleBackColor = true;
      this.BtnTranSerial.Click += new System.EventHandler(this.BtnTranSerial_Click);
      // 
      // BtnTranReadCom
      // 
      this.BtnTranReadCom.Location = new System.Drawing.Point(24, 300);
      this.BtnTranReadCom.Name = "BtnTranReadCom";
      this.BtnTranReadCom.Size = new System.Drawing.Size(153, 35);
      this.BtnTranReadCom.TabIndex = 12;
      this.BtnTranReadCom.Text = "Tran. Read Committed";
      this.BtnTranReadCom.UseVisualStyleBackColor = true;
      this.BtnTranReadCom.Click += new System.EventHandler(this.BtnTranReadCom_Click);
      // 
      // DtgGeneral
      // 
      this.DtgGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DtgGeneral.Location = new System.Drawing.Point(21, 34);
      this.DtgGeneral.Name = "DtgGeneral";
      this.DtgGeneral.Size = new System.Drawing.Size(657, 240);
      this.DtgGeneral.TabIndex = 11;

      // 
      // BtnBorrar
      // 
      this.BtnBorrar.Location = new System.Drawing.Point(26, 456);
      this.BtnBorrar.Name = "BtnBorrar";
      this.BtnBorrar.Size = new System.Drawing.Size(150, 30);
      this.BtnBorrar.TabIndex = 22;
      this.BtnBorrar.Text = "Borrar materia";
      this.BtnBorrar.UseVisualStyleBackColor = true;
      this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
      // 
      // FrmTransac
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(699, 508);
      this.Controls.Add(this.BtnBorrar);
      this.Controls.Add(this.Label1);
      this.Controls.Add(this.BtnInsertTran);
      this.Controls.Add(this.BtnSelectTran);
      this.Controls.Add(this.BtnUpdateTran);
      this.Controls.Add(this.BtnInsert);
      this.Controls.Add(this.BtnSelectUpdate);
      this.Controls.Add(this.BtnSelect);
      this.Controls.Add(this.BtnFinTran);
      this.Controls.Add(this.BtnTranSerial);
      this.Controls.Add(this.BtnTranReadCom);
      this.Controls.Add(this.DtgGeneral);
      this.Name = "FrmTransac";
      this.Text = "Transacción:";
      this.Load += new System.EventHandler(this.FrmTransac_Load);
      ((System.ComponentModel.ISupportInitialize)(this.DtgGeneral)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    internal System.Windows.Forms.Label Label1;
    internal System.Windows.Forms.Button BtnInsertTran;
    internal System.Windows.Forms.Button BtnSelectTran;
    internal System.Windows.Forms.Button BtnUpdateTran;
    internal System.Windows.Forms.Button BtnInsert;
    internal System.Windows.Forms.Button BtnSelectUpdate;
    internal System.Windows.Forms.Button BtnSelect;
    internal System.Windows.Forms.Button BtnFinTran;
    internal System.Windows.Forms.Button BtnTranSerial;
    internal System.Windows.Forms.Button BtnTranReadCom;
    internal System.Windows.Forms.DataGridView DtgGeneral;
    private System.Windows.Forms.Button BtnBorrar;
  }
}