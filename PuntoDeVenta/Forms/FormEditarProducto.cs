using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDominio;
using CapaEntidad;


namespace PuntoDeVenta.Forms
{
    public partial class FormEditarProducto : FormBase
    {
        public FormEditarProducto(FormsProduct Productos)
        {
            InitializeComponent();
        }

        CDO_Procedimientos Procedimientos = new CDO_Procedimientos();
        CDO_Productos Productos = new CDO_Productos();
        CE_Productos Producto = new CE_Productos();


        public delegate void UpdateDelegate(Object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }
        protected void Actualizar()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }


        private void FormEditarProducto_Load(object sender, EventArgs e)
        {

        }

        private void TxtNombrProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtDescProducto.Focus();
                e.Handled = true;
            }

        }

        private void TxDexcProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPresentacion.Focus();
                e.Handled = true;
            }

        }

        private void txtPresentacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtCostoUnit.Focus();
                e.Handled = true;
            }


        }

        private void txtPrecioVta_Leave(object sender, EventArgs e)
        {
            Procedimientos.FomratoMoneda(txtPrecioVta);


        }



        private void txtCostoUnit_Leave(object sender, EventArgs e)
        {
            Procedimientos.FomratoMoneda(txtCostoUnit);
        }

        private void txtCostoUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPrecioVta.Focus();
                e.Handled = true;
            }


        }

        private void txtPrecioVta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CbTipoCargo.Focus();
                e.Handled = true;
            }
        }

        private void CbTipoCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnEditar.Focus();
            e.Handled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }
        public override void Editar()
        {
            try
            {
                if (TxtCodProd.Text == string.Empty || txtDescProducto.Text == string.Empty || txtPresentacion.Text == string.Empty || txtCostoUnit.Text == string.Empty || txtPrecioVta.Text == string.Empty
                    || CbTipoCargo.Text == string.Empty)
                {
                    MessageBox.Show("Debe completar todos los campos", "Agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Producto.id_Productos = Convert.ToInt32(txtId_Producto.Text.Trim());
                    Producto.Codigo = TxtCodProd.Text.Trim();
                    Producto.Nombre = TxtNombrProd.Text.Trim();
                    Producto.Descripcion = txtDescProducto.Text.Trim();
                    Producto.Presentacion = txtPresentacion.Text.Trim();
                    Producto.Costo_Unitario = Convert.ToDecimal(txtCostoUnit.Text.Trim());
                    Producto.Precio_Venta = Convert.ToDecimal(txtPrecioVta.Text.Trim());
                    Producto.Tipo_Cargo = CbTipoCargo.Text.Trim();

                    Productos.EditarProducto(Producto);
                    MessageBox.Show("El producto se ha editado correctamente", "Editar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    Actualizar();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El producto no fue editado por: " + ex.Message, "Editar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
