namespace MainCorreo
{
    partial class FormPpal 
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEstadoEntregado = new System.Windows.Forms.Label();
            this.lblEstadoEnViaje = new System.Windows.Forms.Label();
            this.lblEstadoIngresado = new System.Windows.Forms.Label();
            this.lstEstadoEntregado = new System.Windows.Forms.ListBox();
            this.cmsListas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstEstadoEnViaje = new System.Windows.Forms.ListBox();
            this.lstEstadoIngresado = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTrackingID = new System.Windows.Forms.Label();
            this.mtxTrackingID = new System.Windows.Forms.MaskedTextBox();
            this.rtbMostrar = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.cmsListas.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEstadoEntregado);
            this.groupBox1.Controls.Add(this.lblEstadoEnViaje);
            this.groupBox1.Controls.Add(this.lblEstadoIngresado);
            this.groupBox1.Controls.Add(this.lstEstadoEntregado);
            this.groupBox1.Controls.Add(this.lstEstadoEnViaje);
            this.groupBox1.Controls.Add(this.lstEstadoIngresado);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1228, 415);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado Paquetes";
            // 
            // lblEstadoEntregado
            // 
            this.lblEstadoEntregado.AutoSize = true;
            this.lblEstadoEntregado.Location = new System.Drawing.Point(850, 45);
            this.lblEstadoEntregado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoEntregado.Name = "lblEstadoEntregado";
            this.lblEstadoEntregado.Size = new System.Drawing.Size(84, 20);
            this.lblEstadoEntregado.TabIndex = 5;
            this.lblEstadoEntregado.Text = "Entregado";
            // 
            // lblEstadoEnViaje
            // 
            this.lblEstadoEnViaje.AutoSize = true;
            this.lblEstadoEnViaje.Location = new System.Drawing.Point(442, 45);
            this.lblEstadoEnViaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoEnViaje.Name = "lblEstadoEnViaje";
            this.lblEstadoEnViaje.Size = new System.Drawing.Size(68, 20);
            this.lblEstadoEnViaje.TabIndex = 4;
            this.lblEstadoEnViaje.Text = "En Viaje";
            // 
            // lblEstadoIngresado
            // 
            this.lblEstadoIngresado.AutoSize = true;
            this.lblEstadoIngresado.Location = new System.Drawing.Point(22, 45);
            this.lblEstadoIngresado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoIngresado.Name = "lblEstadoIngresado";
            this.lblEstadoIngresado.Size = new System.Drawing.Size(81, 20);
            this.lblEstadoIngresado.TabIndex = 3;
            this.lblEstadoIngresado.Text = "Ingresado";
            // 
            // lstEstadoEntregado
            // 
            this.lstEstadoEntregado.ContextMenuStrip = this.cmsListas;
            this.lstEstadoEntregado.FormattingEnabled = true;
            this.lstEstadoEntregado.ItemHeight = 20;
            this.lstEstadoEntregado.Location = new System.Drawing.Point(855, 69);
            this.lstEstadoEntregado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstEstadoEntregado.Name = "lstEstadoEntregado";
            this.lstEstadoEntregado.Size = new System.Drawing.Size(330, 324);
            this.lstEstadoEntregado.TabIndex = 2;
            // 
            // cmsListas
            // 
            this.cmsListas.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsListas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem});
            this.cmsListas.Name = "cmsListas";
            this.cmsListas.Size = new System.Drawing.Size(147, 34);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.MostrarToolStripMenuItem_Click);
            // 
            // lstEstadoEnViaje
            // 
            this.lstEstadoEnViaje.FormattingEnabled = true;
            this.lstEstadoEnViaje.ItemHeight = 20;
            this.lstEstadoEnViaje.Location = new System.Drawing.Point(447, 69);
            this.lstEstadoEnViaje.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstEstadoEnViaje.Name = "lstEstadoEnViaje";
            this.lstEstadoEnViaje.Size = new System.Drawing.Size(330, 324);
            this.lstEstadoEnViaje.TabIndex = 1;
            // 
            // lstEstadoIngresado
            // 
            this.lstEstadoIngresado.FormattingEnabled = true;
            this.lstEstadoIngresado.ItemHeight = 20;
            this.lstEstadoIngresado.Location = new System.Drawing.Point(27, 69);
            this.lstEstadoIngresado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstEstadoIngresado.Name = "lstEstadoIngresado";
            this.lstEstadoIngresado.Size = new System.Drawing.Size(330, 324);
            this.lstEstadoIngresado.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDireccion);
            this.groupBox2.Controls.Add(this.btnMostrar);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.lblDireccion);
            this.groupBox2.Controls.Add(this.lblTrackingID);
            this.groupBox2.Controls.Add(this.mtxTrackingID);
            this.groupBox2.Location = new System.Drawing.Point(873, 443);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(374, 186);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paquete";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(10, 128);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(198, 26);
            this.txtDireccion.TabIndex = 10;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(219, 114);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(146, 54);
            this.btnMostrar.TabIndex = 9;
            this.btnMostrar.Text = "Mostrar Todos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(219, 29);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(146, 75);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(22, 102);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(75, 20);
            this.lblDireccion.TabIndex = 7;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblTrackingID
            // 
            this.lblTrackingID.AutoSize = true;
            this.lblTrackingID.Location = new System.Drawing.Point(22, 29);
            this.lblTrackingID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrackingID.Name = "lblTrackingID";
            this.lblTrackingID.Size = new System.Drawing.Size(90, 20);
            this.lblTrackingID.TabIndex = 5;
            this.lblTrackingID.Text = "Tracking ID";
            // 
            // mtxTrackingID
            // 
            this.mtxTrackingID.Location = new System.Drawing.Point(9, 54);
            this.mtxTrackingID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtxTrackingID.Mask = "000-000-0000";
            this.mtxTrackingID.Name = "mtxTrackingID";
            this.mtxTrackingID.Size = new System.Drawing.Size(199, 26);
            this.mtxTrackingID.TabIndex = 0;
            // 
            // rtbMostrar
            // 
            this.rtbMostrar.BackColor = System.Drawing.SystemColors.Control;
            this.rtbMostrar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rtbMostrar.Location = new System.Drawing.Point(18, 443);
            this.rtbMostrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbMostrar.Name = "rtbMostrar";
            this.rtbMostrar.Size = new System.Drawing.Size(844, 184);
            this.rtbMostrar.TabIndex = 3;
            this.rtbMostrar.Text = "";
            // 
            // FormPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 648);
            this.Controls.Add(this.rtbMostrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPpal";
            this.Text = "Correo UTN por Luciano Gil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPpal_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cmsListas.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEstadoIngresado;
        private System.Windows.Forms.ListBox lstEstadoEntregado;
        private System.Windows.Forms.ListBox lstEstadoEnViaje;
        private System.Windows.Forms.ListBox lstEstadoIngresado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtbMostrar;
        private System.Windows.Forms.Label lblEstadoEntregado;
        private System.Windows.Forms.Label lblEstadoEnViaje;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTrackingID;
        private System.Windows.Forms.MaskedTextBox mtxTrackingID;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ContextMenuStrip cmsListas;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
    }
}

