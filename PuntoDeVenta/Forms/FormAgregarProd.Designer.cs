
namespace PuntoDeVenta.Forms
{
    partial class FormAgregarProd
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
            this.TxtCodProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxDexcProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCostoUnit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecioVta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CbTipoCargo = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CbPresentacion = new System.Windows.Forms.ComboBox();
            this.CbNombres = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Producto";
            // 
            // TxtCodProd
            // 
            this.TxtCodProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodProd.Location = new System.Drawing.Point(15, 41);
            this.TxtCodProd.Multiline = true;
            this.TxtCodProd.Name = "TxtCodProd";
            this.TxtCodProd.ReadOnly = true;
            this.TxtCodProd.Size = new System.Drawing.Size(149, 24);
            this.TxtCodProd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Producto";
            // 
            // TxDexcProducto
            // 
            this.TxDexcProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxDexcProducto.Location = new System.Drawing.Point(15, 115);
            this.TxDexcProducto.Multiline = true;
            this.TxDexcProducto.Name = "TxDexcProducto";
            this.TxDexcProducto.Size = new System.Drawing.Size(351, 28);
            this.TxDexcProducto.TabIndex = 4;
            this.TxDexcProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxDexcProducto_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripcion Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(400, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Presentacion";
            // 
            // txtCostoUnit
            // 
            this.txtCostoUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoUnit.Location = new System.Drawing.Point(15, 197);
            this.txtCostoUnit.Multiline = true;
            this.txtCostoUnit.Name = "txtCostoUnit";
            this.txtCostoUnit.Size = new System.Drawing.Size(138, 26);
            this.txtCostoUnit.TabIndex = 6;
            this.txtCostoUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoUnit_KeyPress);
            this.txtCostoUnit.Leave += new System.EventHandler(this.txtCostoUnit_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Costo Unitario";
            // 
            // txtPrecioVta
            // 
            this.txtPrecioVta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVta.Location = new System.Drawing.Point(185, 197);
            this.txtPrecioVta.Multiline = true;
            this.txtPrecioVta.Name = "txtPrecioVta";
            this.txtPrecioVta.Size = new System.Drawing.Size(170, 26);
            this.txtPrecioVta.TabIndex = 7;
            this.txtPrecioVta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVta_KeyPress);
            this.txtPrecioVta.Leave += new System.EventHandler(this.txtPrecioVta_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(187, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Precio Venta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(394, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tipo Cargo";
            // 
            // CbTipoCargo
            // 
            this.CbTipoCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbTipoCargo.FormattingEnabled = true;
            this.CbTipoCargo.Items.AddRange(new object[] {
            "IVA 16%",
            "IVA 5%"});
            this.CbTipoCargo.Location = new System.Drawing.Point(398, 195);
            this.CbTipoCargo.Name = "CbTipoCargo";
            this.CbTipoCargo.Size = new System.Drawing.Size(138, 28);
            this.CbTipoCargo.TabIndex = 8;
            this.CbTipoCargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbTipoCargo_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(185, 267);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(170, 47);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 47);
            this.button1.TabIndex = 21;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CbPresentacion
            // 
            this.CbPresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbPresentacion.FormattingEnabled = true;
            this.CbPresentacion.Items.AddRange(new object[] {
            "Kgs",
            "Lbs",
            "Lts",
            "Unidad",
            "Grs",
            "Mlts"});
            this.CbPresentacion.Location = new System.Drawing.Point(398, 115);
            this.CbPresentacion.Name = "CbPresentacion";
            this.CbPresentacion.Size = new System.Drawing.Size(138, 28);
            this.CbPresentacion.TabIndex = 5;
            // 
            // CbNombres
            // 
            this.CbNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbNombres.FormattingEnabled = true;
            this.CbNombres.Items.AddRange(new object[] {
            "Manzana",
            "Peras",
            "Sandias",
            "Naranjas",
            "Limones",
            "Cacahuates Sabritas",
            "Sabritas Rojas",
            "Sabritas Verdes",
            "Doritos Rojos",
            "Rufles",
            "Huevos",
            "Salchicha",
            "Jamon",
            "Chorizo"});
            this.CbNombres.Location = new System.Drawing.Point(191, 38);
            this.CbNombres.Name = "CbNombres";
            this.CbNombres.Size = new System.Drawing.Size(164, 28);
            this.CbNombres.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(394, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(397, 35);
            this.txtCantidad.Multiline = true;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(130, 28);
            this.txtCantidad.TabIndex = 3;
            // 
            // FormAgregarProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 343);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CbNombres);
            this.Controls.Add(this.CbPresentacion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.CbTipoCargo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrecioVta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCostoUnit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxDexcProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCodProd);
            this.Controls.Add(this.label1);
            this.Name = "FormAgregarProd";
            this.Text = "Agregar Producto";
            this.Load += new System.EventHandler(this.FormAgregarProd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCodProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxDexcProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecioVta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox CbTipoCargo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtCostoUnit;
        public System.Windows.Forms.ComboBox CbPresentacion;
        public System.Windows.Forms.ComboBox CbNombres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCantidad;
    }
}