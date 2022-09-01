namespace PjPlanillaVentas
{
    partial class frmPlanillaDeVentas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.lvEstadisticas = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNcedula = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.Cantdad = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lvFactura = new System.Windows.Forms.ListView();
            this.lblNfactura = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Planilla de ventas ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "N°Cedula";
            // 
            // cboProducto
            // 
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Items.AddRange(new object[] {
            "PS5 + 1 Mando",
            "PS4 + 1 Mando",
            "Mando PS5",
            "Mando PS4"});
            this.cboProducto.Location = new System.Drawing.Point(29, 61);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(176, 23);
            this.cboProducto.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(779, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(38, 15);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Dirección";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "label6";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(536, 61);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(54, 600);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Location = new System.Drawing.Point(54, 403);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(137, 23);
            this.btnEstadisticas.TabIndex = 10;
            this.btnEstadisticas.Text = "Registrar Boleta";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            // 
            // lvEstadisticas
            // 
            this.lvEstadisticas.Location = new System.Drawing.Point(54, 447);
            this.lvEstadisticas.Name = "lvEstadisticas";
            this.lvEstadisticas.Size = new System.Drawing.Size(565, 136);
            this.lvEstadisticas.TabIndex = 11;
            this.lvEstadisticas.UseCompatibleStateImageBehavior = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Estadisticas";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(133, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(126, 23);
            this.txtNombre.TabIndex = 13;
            // 
            // txtNcedula
            // 
            this.txtNcedula.Location = new System.Drawing.Point(133, 86);
            this.txtNcedula.Name = "txtNcedula";
            this.txtNcedula.Size = new System.Drawing.Size(126, 23);
            this.txtNcedula.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(446, 43);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(210, 23);
            this.textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(446, 86);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(210, 23);
            this.textBox4.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.Cantdad);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.lbl5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cboProducto);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Location = new System.Drawing.Point(54, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 115);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(381, 61);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 23);
            this.txtCantidad.TabIndex = 7;
            // 
            // Cantdad
            // 
            this.Cantdad.AutoSize = true;
            this.Cantdad.Location = new System.Drawing.Point(381, 29);
            this.Cantdad.Name = "Cantdad";
            this.Cantdad.Size = new System.Drawing.Size(55, 15);
            this.Cantdad.TabIndex = 6;
            this.Cantdad.Text = "Cantidad";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(245, 61);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 23);
            this.txtPrecio.TabIndex = 5;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(245, 29);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(40, 15);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "Precio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Producto";
            // 
            // lvFactura
            // 
            this.lvFactura.Location = new System.Drawing.Point(54, 268);
            this.lvFactura.Name = "lvFactura";
            this.lvFactura.Size = new System.Drawing.Size(675, 129);
            this.lvFactura.TabIndex = 18;
            this.lvFactura.UseCompatibleStateImageBehavior = false;
            // 
            // lblNfactura
            // 
            this.lblNfactura.AutoSize = true;
            this.lblNfactura.Location = new System.Drawing.Point(120, 9);
            this.lblNfactura.Name = "lblNfactura";
            this.lblNfactura.Size = new System.Drawing.Size(44, 15);
            this.lblNfactura.TabIndex = 19;
            this.lblNfactura.Text = "label11";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Importe";
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(109, 250);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(44, 15);
            this.lblImporte.TabIndex = 21;
            this.lblImporte.Text = "label10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(705, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Fecha Actual";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "N°Factura";
            // 
            // frmPlanillaDeVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 657);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblNfactura);
            this.Controls.Add(this.lvFactura);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtNcedula);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lvEstadisticas);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPlanillaDeVentas";
            this.Text = "Planilla De Ventas ";
            this.Load += new System.EventHandler(this.frmPlanillaDeVentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cboProducto;
        private Label label3;
        private Label lblFecha;
        private Label label5;
        private Label label6;
        private Button btnRegistrar;
        private Button btnSalir;
        private Button btnEstadisticas;
        private ListView lvEstadisticas;
        private Label label7;
        private TextBox txtNombre;
        private TextBox txtNcedula;
        private TextBox textBox3;
        private TextBox textBox4;
        private GroupBox groupBox1;
        private TextBox txtCantidad;
        private Label Cantdad;
        private TextBox txtPrecio;
        private Label lbl5;
        private Label label8;
        private ListView lvFactura;
        private Label lblNfactura;
        private Label label9;
        private Label lblImporte;
        private Label label4;
        private Label label10;
    }
}