namespace pryGarciaIEFI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarSociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarSociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarOEliminarSociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.listadoDeSociosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeSociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actividadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.barrioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.sociosToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(448, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            this.sistemaToolStripMenuItem.Click += new System.EventHandler(this.sistemaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // sociosToolStripMenuItem
            // 
            this.sociosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarSociosToolStripMenuItem,
            this.consultarSociosToolStripMenuItem,
            this.modificarOEliminarSociosToolStripMenuItem,
            this.toolStripSeparator1,
            this.listadoDeSociosToolStripMenuItem1,
            this.listadoDeSociosToolStripMenuItem,
            this.actividadToolStripMenuItem1,
            this.barrioToolStripMenuItem1});
            this.sociosToolStripMenuItem.Name = "sociosToolStripMenuItem";
            this.sociosToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.sociosToolStripMenuItem.Text = "Socios";
            // 
            // agregarSociosToolStripMenuItem
            // 
            this.agregarSociosToolStripMenuItem.Name = "agregarSociosToolStripMenuItem";
            this.agregarSociosToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.agregarSociosToolStripMenuItem.Text = "Agregar Socios...";
            this.agregarSociosToolStripMenuItem.Click += new System.EventHandler(this.agregarSociosToolStripMenuItem_Click);
            // 
            // consultarSociosToolStripMenuItem
            // 
            this.consultarSociosToolStripMenuItem.Name = "consultarSociosToolStripMenuItem";
            this.consultarSociosToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.consultarSociosToolStripMenuItem.Text = "Consultar Socios...";
            this.consultarSociosToolStripMenuItem.Click += new System.EventHandler(this.consultarSociosToolStripMenuItem_Click);
            // 
            // modificarOEliminarSociosToolStripMenuItem
            // 
            this.modificarOEliminarSociosToolStripMenuItem.Name = "modificarOEliminarSociosToolStripMenuItem";
            this.modificarOEliminarSociosToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.modificarOEliminarSociosToolStripMenuItem.Text = "Modificar o Eliminar Socios...";
            this.modificarOEliminarSociosToolStripMenuItem.Click += new System.EventHandler(this.modificarOEliminarSociosToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(224, 6);
            // 
            // listadoDeSociosToolStripMenuItem1
            // 
            this.listadoDeSociosToolStripMenuItem1.Name = "listadoDeSociosToolStripMenuItem1";
            this.listadoDeSociosToolStripMenuItem1.Size = new System.Drawing.Size(227, 22);
            this.listadoDeSociosToolStripMenuItem1.Text = "Listado de socios...";
            this.listadoDeSociosToolStripMenuItem1.Click += new System.EventHandler(this.listadoDeSociosToolStripMenuItem1_Click);
            // 
            // listadoDeSociosToolStripMenuItem
            // 
            this.listadoDeSociosToolStripMenuItem.Name = "listadoDeSociosToolStripMenuItem";
            this.listadoDeSociosToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.listadoDeSociosToolStripMenuItem.Text = "Listado de saldos...";
            this.listadoDeSociosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeSociosToolStripMenuItem_Click);
            // 
            // actividadToolStripMenuItem1
            // 
            this.actividadToolStripMenuItem1.Name = "actividadToolStripMenuItem1";
            this.actividadToolStripMenuItem1.Size = new System.Drawing.Size(227, 22);
            this.actividadToolStripMenuItem1.Text = "Actividad";
            this.actividadToolStripMenuItem1.Click += new System.EventHandler(this.actividadToolStripMenuItem1_Click);
            // 
            // barrioToolStripMenuItem1
            // 
            this.barrioToolStripMenuItem1.Name = "barrioToolStripMenuItem1";
            this.barrioToolStripMenuItem1.Size = new System.Drawing.Size(227, 22);
            this.barrioToolStripMenuItem1.Text = "Barrio";
            this.barrioToolStripMenuItem1.Click += new System.EventHandler(this.barrioToolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(40, 20);
            this.salirToolStripMenuItem1.Text = "salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-13, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 359);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(216, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(448, 388);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMenu";
            this.Text = "Menu Prinsipal";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarSociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarSociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarOEliminarSociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem listadoDeSociosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listadoDeSociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actividadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem barrioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

