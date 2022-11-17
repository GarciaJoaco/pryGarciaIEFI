namespace pryGarciaIEFI
{
    partial class frmConsultarSocios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarSocios));
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCodigoCliente = new System.Windows.Forms.Label();
            this.gpbDatosSocios = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMostrarBarrio = new System.Windows.Forms.Label();
            this.lblMostrarACtividad = new System.Windows.Forms.Label();
            this.lblMostrarSaldo = new System.Windows.Forms.Label();
            this.lblMostrarNombre = new System.Windows.Forms.Label();
            this.lblMostrarDireccion = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gpbDatosSocios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(198, 70);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(146, 24);
            this.txtDNI.TabIndex = 32;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(265, 97);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 32);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCodigoCliente
            // 
            this.lblCodigoCliente.AutoSize = true;
            this.lblCodigoCliente.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCliente.Location = new System.Drawing.Point(12, 73);
            this.lblCodigoCliente.Name = "lblCodigoCliente";
            this.lblCodigoCliente.Size = new System.Drawing.Size(171, 18);
            this.lblCodigoCliente.TabIndex = 29;
            this.lblCodigoCliente.Text = "Ingrese DNI de socio:";
            // 
            // gpbDatosSocios
            // 
            this.gpbDatosSocios.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gpbDatosSocios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gpbDatosSocios.BackgroundImage")));
            this.gpbDatosSocios.Controls.Add(this.lblNombre);
            this.gpbDatosSocios.Controls.Add(this.lblMostrarBarrio);
            this.gpbDatosSocios.Controls.Add(this.lblMostrarACtividad);
            this.gpbDatosSocios.Controls.Add(this.lblMostrarSaldo);
            this.gpbDatosSocios.Controls.Add(this.lblMostrarNombre);
            this.gpbDatosSocios.Controls.Add(this.lblMostrarDireccion);
            this.gpbDatosSocios.Controls.Add(this.lblDireccion);
            this.gpbDatosSocios.Controls.Add(this.lblSaldo);
            this.gpbDatosSocios.Controls.Add(this.lblActividad);
            this.gpbDatosSocios.Controls.Add(this.lblBarrio);
            this.gpbDatosSocios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDatosSocios.ForeColor = System.Drawing.Color.Black;
            this.gpbDatosSocios.Location = new System.Drawing.Point(25, 125);
            this.gpbDatosSocios.Name = "gpbDatosSocios";
            this.gpbDatosSocios.Size = new System.Drawing.Size(333, 283);
            this.gpbDatosSocios.TabIndex = 31;
            this.gpbDatosSocios.TabStop = false;
            this.gpbDatosSocios.Text = "Datos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(26, 49);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 18);
            this.lblNombre.TabIndex = 16;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblMostrarBarrio
            // 
            this.lblMostrarBarrio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostrarBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarBarrio.Location = new System.Drawing.Point(117, 139);
            this.lblMostrarBarrio.Name = "lblMostrarBarrio";
            this.lblMostrarBarrio.Size = new System.Drawing.Size(170, 36);
            this.lblMostrarBarrio.TabIndex = 23;
            // 
            // lblMostrarACtividad
            // 
            this.lblMostrarACtividad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostrarACtividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarACtividad.Location = new System.Drawing.Point(117, 184);
            this.lblMostrarACtividad.Name = "lblMostrarACtividad";
            this.lblMostrarACtividad.Size = new System.Drawing.Size(159, 35);
            this.lblMostrarACtividad.TabIndex = 24;
            // 
            // lblMostrarSaldo
            // 
            this.lblMostrarSaldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostrarSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarSaldo.Location = new System.Drawing.Point(117, 229);
            this.lblMostrarSaldo.Name = "lblMostrarSaldo";
            this.lblMostrarSaldo.Size = new System.Drawing.Size(159, 36);
            this.lblMostrarSaldo.TabIndex = 25;
            this.lblMostrarSaldo.Click += new System.EventHandler(this.lblMostrarSaldo_Click);
            // 
            // lblMostrarNombre
            // 
            this.lblMostrarNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostrarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarNombre.Location = new System.Drawing.Point(117, 48);
            this.lblMostrarNombre.Name = "lblMostrarNombre";
            this.lblMostrarNombre.Size = new System.Drawing.Size(159, 36);
            this.lblMostrarNombre.TabIndex = 21;
            // 
            // lblMostrarDireccion
            // 
            this.lblMostrarDireccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostrarDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarDireccion.Location = new System.Drawing.Point(117, 93);
            this.lblMostrarDireccion.Name = "lblMostrarDireccion";
            this.lblMostrarDireccion.Size = new System.Drawing.Size(202, 32);
            this.lblMostrarDireccion.TabIndex = 22;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(24, 94);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(85, 18);
            this.lblDireccion.TabIndex = 18;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(26, 230);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(56, 18);
            this.lblSaldo.TabIndex = 17;
            this.lblSaldo.Text = "Saldo:";
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividad.Location = new System.Drawing.Point(26, 185);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(80, 18);
            this.lblActividad.TabIndex = 20;
            this.lblActividad.Text = "Actividad:";
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrio.Location = new System.Drawing.Point(26, 140);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(59, 18);
            this.lblBarrio.TabIndex = 19;
            this.lblBarrio.Text = "Barrio:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(111, -10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // frmConsultarSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(366, 418);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblCodigoCliente);
            this.Controls.Add(this.gpbDatosSocios);
            this.Name = "frmConsultarSocios";
            this.Text = "ConsultarSocios";
            this.Load += new System.EventHandler(this.frmConsultarSocios_Load);
            this.gpbDatosSocios.ResumeLayout(false);
            this.gpbDatosSocios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCodigoCliente;
        private System.Windows.Forms.GroupBox gpbDatosSocios;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMostrarBarrio;
        private System.Windows.Forms.Label lblMostrarACtividad;
        private System.Windows.Forms.Label lblMostrarSaldo;
        private System.Windows.Forms.Label lblMostrarNombre;
        private System.Windows.Forms.Label lblMostrarDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}