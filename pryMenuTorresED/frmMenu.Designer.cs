namespace pryMenuTorresED
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructurasLinealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lDEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estNoLinealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaEnSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.Color.Transparent;
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.estructurasLinealesToolStripMenuItem,
            this.estNoLinealesToolStripMenuItem,
            this.bDToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(377, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // estructurasLinealesToolStripMenuItem
            // 
            this.estructurasLinealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colaToolStripMenuItem,
            this.pilaToolStripMenuItem,
            this.lSToolStripMenuItem,
            this.lDEToolStripMenuItem});
            this.estructurasLinealesToolStripMenuItem.Name = "estructurasLinealesToolStripMenuItem";
            this.estructurasLinealesToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.estructurasLinealesToolStripMenuItem.Text = "Est. Lineales";
            // 
            // colaToolStripMenuItem
            // 
            this.colaToolStripMenuItem.Name = "colaToolStripMenuItem";
            this.colaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colaToolStripMenuItem.Text = "Cola";
            this.colaToolStripMenuItem.Click += new System.EventHandler(this.colaToolStripMenuItem_Click);
            // 
            // pilaToolStripMenuItem
            // 
            this.pilaToolStripMenuItem.Name = "pilaToolStripMenuItem";
            this.pilaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pilaToolStripMenuItem.Text = "Pila";
            this.pilaToolStripMenuItem.Click += new System.EventHandler(this.pilaToolStripMenuItem_Click);
            // 
            // lSToolStripMenuItem
            // 
            this.lSToolStripMenuItem.Name = "lSToolStripMenuItem";
            this.lSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lSToolStripMenuItem.Text = "L.S";
            this.lSToolStripMenuItem.Click += new System.EventHandler(this.lSToolStripMenuItem_Click);
            // 
            // lDEToolStripMenuItem
            // 
            this.lDEToolStripMenuItem.Name = "lDEToolStripMenuItem";
            this.lDEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lDEToolStripMenuItem.Text = "L.D.E";
            this.lDEToolStripMenuItem.Click += new System.EventHandler(this.lDEToolStripMenuItem_Click);
            // 
            // estNoLinealesToolStripMenuItem
            // 
            this.estNoLinealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arbolesToolStripMenuItem,
            this.grafosToolStripMenuItem});
            this.estNoLinealesToolStripMenuItem.Name = "estNoLinealesToolStripMenuItem";
            this.estNoLinealesToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.estNoLinealesToolStripMenuItem.Text = "Est.No Lineales";
            // 
            // arbolesToolStripMenuItem
            // 
            this.arbolesToolStripMenuItem.Name = "arbolesToolStripMenuItem";
            this.arbolesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arbolesToolStripMenuItem.Text = "Arboles";
            // 
            // grafosToolStripMenuItem
            // 
            this.grafosToolStripMenuItem.Name = "grafosToolStripMenuItem";
            this.grafosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.grafosToolStripMenuItem.Text = "Grafos";
            // 
            // bDToolStripMenuItem
            // 
            this.bDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarTablaToolStripMenuItem,
            this.consultaEnSQLToolStripMenuItem});
            this.bDToolStripMenuItem.Name = "bDToolStripMenuItem";
            this.bDToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.bDToolStripMenuItem.Text = "B.D";
            // 
            // mostrarTablaToolStripMenuItem
            // 
            this.mostrarTablaToolStripMenuItem.Name = "mostrarTablaToolStripMenuItem";
            this.mostrarTablaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostrarTablaToolStripMenuItem.Text = "Mostrar Tabla";
            // 
            // consultaEnSQLToolStripMenuItem
            // 
            this.consultaEnSQLToolStripMenuItem.Name = "consultaEnSQLToolStripMenuItem";
            this.consultaEnSQLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultaEnSQLToolStripMenuItem.Text = "Consulta en SQL";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(377, 590);
            this.Controls.Add(this.msMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.Name = "frmMenu";
            this.Text = "Menú";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructurasLinealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lDEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estNoLinealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarTablaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaEnSQLToolStripMenuItem;
    }
}

