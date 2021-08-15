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
    public partial class FormAgregarProd : FormBase
    {

        public int f = 0;
        public int cantidad = 1;
        public Int32 i;
        public String celda;
        public DataGridViewCell dgc;
        public Boolean repetido = false;
        public Int32 indexcelda;

        public FormAgregarProd(FormsProduct Productos)
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
        protected void Agregar()
        {
            UpdateEventArgs args= new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }


        private void FormAgregarProd_Load(object sender, EventArgs e)
        {
            GenerarCodigo();

        }
        private  void GenerarCodigo()
        {
            TxtCodProd.Text = "PRDO" + Procedimientos.GenerarCodigo("Productos");
        }

        private void TxtNombrProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxDexcProducto.Focus();
                e.Handled = true;
            }

        }

        private void TxDexcProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CbPresentacion.Focus();
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

        private void txtCostoUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPrecioVta.Focus();
                e.Handled = true;
            }

        }
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxDexcProducto.Focus();
                e.Handled = true;
            }

        }

        private void txtCostoUnit_Leave(object sender, EventArgs e)
        {
            Procedimientos.FomratoMoneda(txtCostoUnit);
        }

        private void txtPrecioVta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CbTipoCargo.Focus();
                e.Handled = true;
            }

        }

        private void txtPrecioVta_Leave(object sender, EventArgs e)
        {
            Procedimientos.FomratoMoneda(txtPrecioVta);

        }

        private void CbTipoCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnAgregar.Focus();
            e.Handled = true;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        public override bool Guardar()
        {
            try
            {
                if (TxtCodProd.Text == string.Empty || txtCantidad.Text == string.Empty || TxDexcProducto.Text == string.Empty || CbPresentacion.Text == string.Empty || txtCostoUnit.Text == string.Empty || txtPrecioVta.Text == string.Empty
                    || CbTipoCargo.Text == string.Empty)
                {
                    MessageBox.Show("Debe completar todos los campos", "Agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int CantidadSum = 0;
                    int CantidadCont = Convert.ToInt32(txtCantidad.Text.Trim());
                    CantidadSum = CantidadSum + CantidadCont;

                    Producto.Codigo = TxtCodProd.Text.Trim();
                    Producto.Nombre = CbNombres.Text.Trim();
                    Producto.Descripcion = TxDexcProducto.Text.Trim();
                    Producto.Presentacion = CbPresentacion.Text.Trim();
                    Producto.Costo_Unitario = Convert.ToDecimal(txtCostoUnit.Text.Trim());
                    Producto.Precio_Venta = Convert.ToDecimal(txtPrecioVta.Text.Trim());
                    Producto.Tipo_Cargo = CbTipoCargo.Text.Trim();
                    Producto.Cantidad = Convert.ToInt32(txtCantidad.Text.Trim());

                    Productos.AgregarProducto(Producto);
                    MessageBox.Show("El producto se ha agregado correctamente", "Agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Procedimientos.LimpiarControles(txtCostoUnit);
                    Procedimientos.LimpiarControles(txtPrecioVta);
                    GenerarCodigo();
                    CbNombres.Focus();
                    Agregar();


                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("El producto no fue agregado por: "+ ex.Message, "Agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           return false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
