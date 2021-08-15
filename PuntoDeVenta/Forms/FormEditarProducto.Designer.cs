
namespace PuntoDeVenta.Forms
{
    partial class FormEditarProducto
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.CbTipoCargo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecioVta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCostoUnit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPresentacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombrProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId_Producto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(168, 257);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(170, 47);
            this.btnEditar.TabIndex = 36;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // CbTipoCargo
            // 
            this.CbTipoCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbTipoCargo.FormattingEnabled = true;
            this.CbTipoCargo.Items.AddRange(new object[] {
            "IVA 15%",
            "IVA 10%"});
            this.CbTipoCargo.Location = new System.Drawing.Point(385, 207);
            this.CbTipoCargo.Name = "CbTipoCargo";
            this.CbTipoCargo.Size = new System.Drawing.Size(138, 28);
            this.CbTipoCargo.TabIndex = 35;
            this.CbTipoCargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbTipoCargo_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(381, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Tipo Cargo";
            // 
            // txtPrecioVta
            // 
            this.txtPrecioVta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVta.Location = new System.Drawing.Point(172, 209);
            this.txtPrecioVta.Multiline = true;
            this.txtPrecioVta.Name = "txtPrecioVta";
            this.txtPrecioVta.Size = new System.Drawing.Size(170, 24);
            this.txtPrecioVta.TabIndex = 33;
            this.txtPrecioVta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVta_KeyPress);
            this.txtPrecioVta.Leave += new System.EventHandler(this.txtPrecioVta_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(174, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Precio Venta";
            // 
            // txtCostoUnit
            // 
            this.txtCostoUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoUnit.Location = new System.Drawing.Point(4, 211);
            this.txtCostoUnit.Multiline = true;
            this.txtCostoUnit.Name = "txtCostoUnit";
            this.txtCostoUnit.Size = new System.Drawing.Size(138, 24);
            this.txtCostoUnit.TabIndex = 31;
            this.txtCostoUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoUnit_KeyPress);
            this.txtCostoUnit.Leave += new System.EventHandler(this.txtCostoUnit_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Costo Unitario";
            // 
            // txtPresentacion
            // 
            this.txtPresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresentacion.Location = new System.Drawing.Point(385, 127);
            this.txtPresentacion.Multiline = true;
            this.txtPresentacion.Name = "txtPresentacion";
            this.txtPresentacion.Size = new System.Drawing.Size(138, 24);
            this.txtPresentacion.TabIndex = 29;
            this.txtPresentacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPresentacion_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(387, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Presentacion";
            // 
            // txtDescProducto
            // 
            this.txtDescProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescProducto.Location = new System.Drawing.Point(2, 127);
            this.txtDescProducto.Multiline = true;
            this.txtDescProducto.Name = "txtDescProducto";
            this.txtDescProducto.Size = new System.Drawing.Size(351, 24);
            this.txtDescProducto.TabIndex = 27;
            this.txtDescProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxDexcProducto_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Descripcion Producto";
            // 
            // TxtNombrProd
            // 
            this.TxtNombrProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombrProd.Location = new System.Drawing.Point(203, 53);
            this.TxtNombrProd.Multiline = true;
            this.TxtNombrProd.Name = "TxtNombrProd";
            this.TxtNombrProd.Size = new System.Drawing.Size(344, 24);
            this.TxtNombrProd.TabIndex = 0;
            this.TxtNombrProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombrProd_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nombre Producto";
            // 
            // TxtCodProd
            // 
            this.TxtCodProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodProd.Location = new System.Drawing.Point(4, 53);
            this.TxtCodProd.Multiline = true;
            this.TxtCodProd.Name = "TxtCodProd";
            this.TxtCodProd.ReadOnly = true;
            this.TxtCodProd.Size = new System.Drawing.Size(187, 24);
            this.TxtCodProd.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Codigo Producto";
            // 
            // txtId_Producto
            // 
            this.txtId_Producto.Location = new System.Drawing.Point(126, 27);
            this.txtId_Producto.Name = "txtId_Producto";
            this.txtId_Producto.Size = new System.Drawing.Size(65, 20);
            this.txtId_Producto.TabIndex = 38;
            this.txtId_Producto.Visible = false;
            // 
            // FormEditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 330);
            this.Controls.Add(this.txtId_Producto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.CbTipoCargo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrecioVta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCostoUnit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPresentacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNombrProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCodProd);
            this.Controls.Add(this.label1);
            this.Name = "FormEditarProducto";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormEditarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.ComboBox CbTipoCargo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtCostoUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtId_Producto;
        public System.Windows.Forms.TextBox txtPrecioVta;
        public System.Windows.Forms.TextBox txtPresentacion;
        public System.Windows.Forms.TextBox txtDescProducto;
        public System.Windows.Forms.TextBox TxtNombrProd;
        public System.Windows.Forms.TextBox TxtCodProd;
    }
}