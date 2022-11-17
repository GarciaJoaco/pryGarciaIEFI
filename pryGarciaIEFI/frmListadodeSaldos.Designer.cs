namespace pryGarciaIEFI
{
    partial class frmListadodeSaldos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadodeSaldos));
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.txtPromedioSaldos = new System.Windows.Forms.TextBox();
            this.txtTotalSocios = new System.Windows.Forms.TextBox();
            this.txtTotalSaldos = new System.Windows.Forms.TextBox();
            this.lblPromedioDeSaldos = new System.Windows.Forms.Label();
            this.lblTotalSocios = new System.Windows.Forms.Label();
            this.lblTotalSaldos = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvListadoSaldos = new System.Windows.Forms.DataGridView();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBREAPELLIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gpbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoSaldos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbDatos
            // 
            this.gpbDatos.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gpbDatos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gpbDatos.BackgroundImage")));
            this.gpbDatos.Controls.Add(this.txtPromedioSaldos);
            this.gpbDatos.Controls.Add(this.txtTotalSocios);
            this.gpbDatos.Controls.Add(this.txtTotalSaldos);
            this.gpbDatos.Controls.Add(this.lblPromedioDeSaldos);
            this.gpbDatos.Controls.Add(this.lblTotalSocios);
            this.gpbDatos.Controls.Add(this.lblTotalSaldos);
            this.gpbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDatos.Location = new System.Drawing.Point(120, 220);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Size = new System.Drawing.Size(450, 148);
            this.gpbDatos.TabIndex = 5;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "Datos";
            // 
            // txtPromedioSaldos
            // 
            this.txtPromedioSaldos.Location = new System.Drawing.Point(276, 117);
            this.txtPromedioSaldos.Name = "txtPromedioSaldos";
            this.txtPromedioSaldos.Size = new System.Drawing.Size(146, 31);
            this.txtPromedioSaldos.TabIndex = 5;
            // 
            // txtTotalSocios
            // 
            this.txtTotalSocios.Location = new System.Drawing.Point(276, 76);
            this.txtTotalSocios.Name = "txtTotalSocios";
            this.txtTotalSocios.Size = new System.Drawing.Size(146, 31);
            this.txtTotalSocios.TabIndex = 4;
            // 
            // txtTotalSaldos
            // 
            this.txtTotalSaldos.Location = new System.Drawing.Point(276, 35);
            this.txtTotalSaldos.Name = "txtTotalSaldos";
            this.txtTotalSaldos.Size = new System.Drawing.Size(146, 31);
            this.txtTotalSaldos.TabIndex = 3;
            // 
            // lblPromedioDeSaldos
            // 
            this.lblPromedioDeSaldos.AutoSize = true;
            this.lblPromedioDeSaldos.Location = new System.Drawing.Point(50, 120);
            this.lblPromedioDeSaldos.Name = "lblPromedioDeSaldos";
            this.lblPromedioDeSaldos.Size = new System.Drawing.Size(197, 25);
            this.lblPromedioDeSaldos.TabIndex = 2;
            this.lblPromedioDeSaldos.Text = "Promedio Saldos:";
            // 
            // lblTotalSocios
            // 
            this.lblTotalSocios.AutoSize = true;
            this.lblTotalSocios.Location = new System.Drawing.Point(50, 79);
            this.lblTotalSocios.Name = "lblTotalSocios";
            this.lblTotalSocios.Size = new System.Drawing.Size(150, 25);
            this.lblTotalSocios.TabIndex = 1;
            this.lblTotalSocios.Text = "Total Socios:";
            // 
            // lblTotalSaldos
            // 
            this.lblTotalSaldos.AutoSize = true;
            this.lblTotalSaldos.Location = new System.Drawing.Point(50, 38);
            this.lblTotalSaldos.Name = "lblTotalSaldos";
            this.lblTotalSaldos.Size = new System.Drawing.Size(151, 25);
            this.lblTotalSaldos.TabIndex = 0;
            this.lblTotalSaldos.Text = "Total Saldos:";
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(12, 166);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(98, 33);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvListadoSaldos
            // 
            this.dgvListadoSaldos.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvListadoSaldos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoSaldos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.NOMBREAPELLIDO,
            this.Saldo});
            this.dgvListadoSaldos.Location = new System.Drawing.Point(120, 8);
            this.dgvListadoSaldos.Name = "dgvListadoSaldos";
            this.dgvListadoSaldos.Size = new System.Drawing.Size(467, 206);
            this.dgvListadoSaldos.TabIndex = 3;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // NOMBREAPELLIDO
            // 
            this.NOMBREAPELLIDO.HeaderText = "Nombre y Apellido";
            this.NOMBREAPELLIDO.Name = "NOMBREAPELLIDO";
            this.NOMBREAPELLIDO.Width = 200;
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // frmListadodeSaldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(582, 373);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.gpbDatos);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvListadoSaldos);
            this.Name = "frmListadodeSaldos";
            this.Text = "frmListadodeSaldos";
            this.Load += new System.EventHandler(this.frmListadodeSaldos_Load);
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoSaldos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDatos;
        private System.Windows.Forms.TextBox txtPromedioSaldos;
        private System.Windows.Forms.TextBox txtTotalSocios;
        private System.Windows.Forms.TextBox txtTotalSaldos;
        private System.Windows.Forms.Label lblPromedioDeSaldos;
        private System.Windows.Forms.Label lblTotalSocios;
        private System.Windows.Forms.Label lblTotalSaldos;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvListadoSaldos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBREAPELLIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}