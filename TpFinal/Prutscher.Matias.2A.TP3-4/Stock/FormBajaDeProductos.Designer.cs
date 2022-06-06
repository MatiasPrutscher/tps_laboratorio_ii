
namespace Stock
{
    partial class FormBajaDeProductos
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
            this.lblTPrecio = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTRubro = new System.Windows.Forms.Label();
            this.lblTProducto = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblRubro = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblTStock = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTPrecio
            // 
            this.lblTPrecio.AutoSize = true;
            this.lblTPrecio.Enabled = false;
            this.lblTPrecio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTPrecio.Location = new System.Drawing.Point(19, 183);
            this.lblTPrecio.Name = "lblTPrecio";
            this.lblTPrecio.Size = new System.Drawing.Size(56, 21);
            this.lblTPrecio.TabIndex = 41;
            this.lblTPrecio.Text = "Precio:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Silver;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(322, 263);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(144, 37);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Silver;
            this.btnBorrar.FlatAppearance.BorderSize = 2;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBorrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBorrar.Location = new System.Drawing.Point(148, 263);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(144, 37);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(150, 36);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(318, 23);
            this.txtCodigo.TabIndex = 0;
            // 
            // lblTRubro
            // 
            this.lblTRubro.AutoSize = true;
            this.lblTRubro.Enabled = false;
            this.lblTRubro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTRubro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTRubro.Location = new System.Drawing.Point(19, 220);
            this.lblTRubro.Name = "lblTRubro";
            this.lblTRubro.Size = new System.Drawing.Size(56, 21);
            this.lblTRubro.TabIndex = 38;
            this.lblTRubro.Text = "Rubro:";
            // 
            // lblTProducto
            // 
            this.lblTProducto.AutoSize = true;
            this.lblTProducto.Enabled = false;
            this.lblTProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTProducto.Location = new System.Drawing.Point(19, 147);
            this.lblTProducto.Name = "lblTProducto";
            this.lblTProducto.Size = new System.Drawing.Size(76, 21);
            this.lblTProducto.TabIndex = 37;
            this.lblTProducto.Text = "Producto:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Enabled = false;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblCodigo.Location = new System.Drawing.Point(20, 38);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(63, 21);
            this.lblCodigo.TabIndex = 36;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblProducto
            // 
            this.lblProducto.BackColor = System.Drawing.Color.White;
            this.lblProducto.Enabled = false;
            this.lblProducto.Location = new System.Drawing.Point(149, 145);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(318, 23);
            this.lblProducto.TabIndex = 43;
            this.lblProducto.Text = "lblProducto";
            // 
            // lblPrecio
            // 
            this.lblPrecio.BackColor = System.Drawing.Color.White;
            this.lblPrecio.Enabled = false;
            this.lblPrecio.Location = new System.Drawing.Point(149, 181);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(318, 23);
            this.lblPrecio.TabIndex = 44;
            this.lblPrecio.Text = "lblPrecio";
            // 
            // lblRubro
            // 
            this.lblRubro.BackColor = System.Drawing.Color.White;
            this.lblRubro.Enabled = false;
            this.lblRubro.Location = new System.Drawing.Point(149, 218);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(318, 23);
            this.lblRubro.TabIndex = 45;
            this.lblRubro.Text = "lblRubro";
            // 
            // lblStock
            // 
            this.lblStock.BackColor = System.Drawing.Color.White;
            this.lblStock.Enabled = false;
            this.lblStock.Location = new System.Drawing.Point(149, 108);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(318, 23);
            this.lblStock.TabIndex = 47;
            this.lblStock.Text = "lblStock";
            // 
            // lblTStock
            // 
            this.lblTStock.AutoSize = true;
            this.lblTStock.Enabled = false;
            this.lblTStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTStock.Location = new System.Drawing.Point(19, 110);
            this.lblTStock.Name = "lblTStock";
            this.lblTStock.Size = new System.Drawing.Size(50, 21);
            this.lblTStock.TabIndex = 46;
            this.lblTStock.Text = "Stock:";
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.Silver;
            this.btnVerificar.FlatAppearance.BorderSize = 2;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVerificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnVerificar.Location = new System.Drawing.Point(149, 65);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(144, 29);
            this.btnVerificar.TabIndex = 1;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // FormBajaDeProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblTStock);
            this.Controls.Add(this.lblRubro);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblTPrecio);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblTRubro);
            this.Controls.Add(this.lblTProducto);
            this.Controls.Add(this.lblCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBajaDeProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja De Productos";
            this.Load += new System.EventHandler(this.FormBajaDeProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTPrecio;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTRubro;
        private System.Windows.Forms.Label lblTProducto;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblRubro;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblTStock;
        private System.Windows.Forms.Button btnVerificar;
    }
}