namespace pryMenuTorresED
{
    partial class frmConsultaDataBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblConsulta = new System.Windows.Forms.Label();
            this.dgvConsultaUno = new System.Windows.Forms.DataGridView();
            this.dgvConsultaDos = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaUno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaDos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.BackColor = System.Drawing.SystemColors.Control;
            this.lblConsulta.Location = new System.Drawing.Point(13, 13);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(87, 13);
            this.lblConsulta.TabIndex = 0;
            this.lblConsulta.Text = "Consulta en SQL";
            // 
            // dgvConsultaUno
            // 
            this.dgvConsultaUno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaUno.Location = new System.Drawing.Point(13, 41);
            this.dgvConsultaUno.Name = "dgvConsultaUno";
            this.dgvConsultaUno.Size = new System.Drawing.Size(775, 150);
            this.dgvConsultaUno.TabIndex = 1;
            // 
            // dgvConsultaDos
            // 
            this.dgvConsultaDos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaDos.Location = new System.Drawing.Point(13, 258);
            this.dgvConsultaDos.Name = "dgvConsultaDos";
            this.dgvConsultaDos.Size = new System.Drawing.Size(775, 179);
            this.dgvConsultaDos.TabIndex = 2;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.OldLace;
            this.btnListar.Location = new System.Drawing.Point(638, 212);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(150, 23);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            // 
            // frmConsultaDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvConsultaDos);
            this.Controls.Add(this.dgvConsultaUno);
            this.Controls.Add(this.lblConsulta);
            this.Name = "frmConsultaDataBase";
            this.Text = "Consulta Data Base";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaUno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaDos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.DataGridView dgvConsultaUno;
        private System.Windows.Forms.DataGridView dgvConsultaDos;
        private System.Windows.Forms.Button btnListar;
    }
}