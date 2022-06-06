
namespace Facturacion
{
    partial class FormPago
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTTotal = new System.Windows.Forms.Label();
            this.cmbCuotas = new System.Windows.Forms.ComboBox();
            this.lblCuotas = new System.Windows.Forms.Label();
            this.lblMtarjeta = new System.Windows.Forms.Label();
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.cmbTarjetas = new System.Windows.Forms.ComboBox();
            this.lblTTarjeta = new System.Windows.Forms.Label();
            this.lblTEfectivo = new System.Windows.Forms.Label();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Silver;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(196, 234);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(144, 37);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Silver;
            this.btnGuardar.FlatAppearance.BorderSize = 2;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGuardar.Location = new System.Drawing.Point(22, 234);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(144, 37);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.Enabled = false;
            this.lblTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotal.Location = new System.Drawing.Point(173, 185);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(171, 23);
            this.lblTotal.TabIndex = 31;
            this.lblTotal.Text = "lblTotal";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTTotal
            // 
            this.lblTTotal.AutoSize = true;
            this.lblTTotal.Enabled = false;
            this.lblTTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTTotal.Location = new System.Drawing.Point(22, 180);
            this.lblTTotal.Name = "lblTTotal";
            this.lblTTotal.Size = new System.Drawing.Size(45, 21);
            this.lblTTotal.TabIndex = 30;
            this.lblTTotal.Text = "Total:";
            // 
            // cmbCuotas
            // 
            this.cmbCuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuotas.FormattingEnabled = true;
            this.cmbCuotas.Items.AddRange(new object[] {
            "1",
            "3",
            "6",
            "12",
            "18",
            "24"});
            this.cmbCuotas.Location = new System.Drawing.Point(173, 110);
            this.cmbCuotas.Name = "cmbCuotas";
            this.cmbCuotas.Size = new System.Drawing.Size(171, 23);
            this.cmbCuotas.TabIndex = 3;
            // 
            // lblCuotas
            // 
            this.lblCuotas.AutoSize = true;
            this.lblCuotas.Enabled = false;
            this.lblCuotas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCuotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblCuotas.Location = new System.Drawing.Point(22, 112);
            this.lblCuotas.Name = "lblCuotas";
            this.lblCuotas.Size = new System.Drawing.Size(145, 21);
            this.lblCuotas.TabIndex = 28;
            this.lblCuotas.Text = "Cantidad de cuotas:";
            // 
            // lblMtarjeta
            // 
            this.lblMtarjeta.AutoSize = true;
            this.lblMtarjeta.Enabled = false;
            this.lblMtarjeta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMtarjeta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMtarjeta.Location = new System.Drawing.Point(22, 83);
            this.lblMtarjeta.Name = "lblMtarjeta";
            this.lblMtarjeta.Size = new System.Drawing.Size(128, 21);
            this.lblMtarjeta.TabIndex = 27;
            this.lblMtarjeta.Text = "Monto en tarjeta:";
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Location = new System.Drawing.Point(173, 81);
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(171, 23);
            this.txtTarjeta.TabIndex = 2;
            // 
            // cmbTarjetas
            // 
            this.cmbTarjetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarjetas.FormattingEnabled = true;
            this.cmbTarjetas.Items.AddRange(new object[] {
            "Efectivo",
            "Electron",
            "Visa",
            "Maestro",
            "Mastercard",
            "Cambio"});
            this.cmbTarjetas.Location = new System.Drawing.Point(173, 52);
            this.cmbTarjetas.Name = "cmbTarjetas";
            this.cmbTarjetas.Size = new System.Drawing.Size(171, 23);
            this.cmbTarjetas.TabIndex = 1;
            // 
            // lblTTarjeta
            // 
            this.lblTTarjeta.AutoSize = true;
            this.lblTTarjeta.Enabled = false;
            this.lblTTarjeta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTTarjeta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTTarjeta.Location = new System.Drawing.Point(22, 54);
            this.lblTTarjeta.Name = "lblTTarjeta";
            this.lblTTarjeta.Size = new System.Drawing.Size(58, 21);
            this.lblTTarjeta.TabIndex = 24;
            this.lblTTarjeta.Text = "Tarjeta:";
            // 
            // lblTEfectivo
            // 
            this.lblTEfectivo.AutoSize = true;
            this.lblTEfectivo.Enabled = false;
            this.lblTEfectivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTEfectivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTEfectivo.Location = new System.Drawing.Point(22, 25);
            this.lblTEfectivo.Name = "lblTEfectivo";
            this.lblTEfectivo.Size = new System.Drawing.Size(67, 21);
            this.lblTEfectivo.TabIndex = 23;
            this.lblTEfectivo.Text = "Efectivo:";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Location = new System.Drawing.Point(173, 23);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(171, 23);
            this.txtEfectivo.TabIndex = 0;
            // 
            // FormPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(367, 278);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTTotal);
            this.Controls.Add(this.cmbCuotas);
            this.Controls.Add(this.lblCuotas);
            this.Controls.Add(this.lblMtarjeta);
            this.Controls.Add(this.txtTarjeta);
            this.Controls.Add(this.cmbTarjetas);
            this.Controls.Add(this.lblTTarjeta);
            this.Controls.Add(this.lblTEfectivo);
            this.Controls.Add(this.txtEfectivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forma de pago";
            this.Load += new System.EventHandler(this.FormPago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTTotal;
        private System.Windows.Forms.ComboBox cmbCuotas;
        private System.Windows.Forms.Label lblCuotas;
        private System.Windows.Forms.Label lblMtarjeta;
        private System.Windows.Forms.TextBox txtTarjeta;
        private System.Windows.Forms.ComboBox cmbTarjetas;
        private System.Windows.Forms.Label lblTTarjeta;
        private System.Windows.Forms.Label lblTEfectivo;
        private System.Windows.Forms.TextBox txtEfectivo;
    }
}