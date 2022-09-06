namespace pjDivisionEntreCero
{
    partial class frmDivisonEntreCero
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumerador = new System.Windows.Forms.TextBox();
            this.txtDenominador = new System.Windows.Forms.TextBox();
            this.btnDividir = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numerador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Denominador ";
            // 
            // txtNumerador
            // 
            this.txtNumerador.Location = new System.Drawing.Point(181, 57);
            this.txtNumerador.Name = "txtNumerador";
            this.txtNumerador.Size = new System.Drawing.Size(100, 23);
            this.txtNumerador.TabIndex = 2;
            // 
            // txtDenominador
            // 
            this.txtDenominador.Location = new System.Drawing.Point(181, 122);
            this.txtDenominador.Name = "txtDenominador";
            this.txtDenominador.Size = new System.Drawing.Size(100, 23);
            this.txtDenominador.TabIndex = 3;
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(65, 179);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 23);
            this.btnDividir.TabIndex = 4;
            this.btnDividir.Text = "Dividir";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(212, 187);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(38, 15);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "label3";
            // 
            // frmDivisonEntreCero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.txtDenominador);
            this.Controls.Add(this.txtNumerador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDivisonEntreCero";
            this.Text = "Division Entre Cero";
            this.Load += new System.EventHandler(this.frmDivisonEntreCero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNumerador;
        private TextBox txtDenominador;
        private Button btnDividir;
        private Label lblResultado;
    }
}