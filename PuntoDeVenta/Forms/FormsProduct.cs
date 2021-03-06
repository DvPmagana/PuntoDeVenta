using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaDominio;

namespace PuntoDeVenta.Forms
{
    public partial class FormsProduct : FormBase
    {
        public FormsProduct()
        {

            InitializeComponent();

        }
        CDO_Procedimientos Procedimientos = new CDO_Procedimientos();
        CDO_Productos Productos = new CDO_Productos();
        CE_Productos Producto = new CE_Productos();

        private void FormsProduct_Load(object sender,EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBSistema_de_VentasDataSet.Productos' table. You can move, or remove it, as needed.
            this.productosTableAdapter.Fill(this.dBSistema_de_VentasDataSet.Productos);
            LoadTheme();
            CargarDatos();
            dataGridView1.Columns[0].Visible = false;//id_Producto
            dataGridView1.Columns[1].Width = 140;//codigo Producto
            dataGridView1.Columns[2].Width = 260;//Nombre del Producto
            dataGridView1.Columns[3].Width = 260;//Cantidad del Producto
            dataGridView1.Columns[4].Width = 300;//Descripcion Producto
            dataGridView1.Columns[5].Width = 150;//Presentacion Producto
            dataGridView1.Columns[6].Width = 140;//Costo Unitario
            dataGridView1.Columns[7].Width = 140;//Precio de Venta
            dataGridView1.Columns[8].Width = 150;//Tipo de Cargo

            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Format = "#,##0.00";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "#,##0.00";

            Procedimientos.AlternarColorFilaDataGridView(dataGridView1);
        }
        private void CargarDatos()
        {
            dataGridView1.DataSource = Procedimientos.CargarDatos("Productos");
            dataGridView1.ClearSelection();
        }


       
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            //label5.ForeColor = ThemeColor.SecondaryColor;
            //label13.ForeColor = ThemeColor.PrimaryColor;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //public virtual bool Guardar() 
        //{
        //    return false;
        //}
        //public virtual bool Editar()
        //{
        //    return false;
        //}

        private void AgPro_UpdateEventHandler(object sender, FormAgregarProd.UpdateEventArgs args)
        {
            CargarDatos();
        }
        private void EdPro_UpdateEventHandler(object sender, FormEditarProducto.UpdateEventArgs args)
        {
            CargarDatos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormAgregarProd AgregarProd = new FormAgregarProd(this);
            AgregarProd.UpdateEventHandler += AgPro_UpdateEventHandler;
            AgregarProd.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
        public override void Eliminar()
        {
            if(dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros para eliminar", "Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if (dataGridView1.SelectedRows == null) 
                    {
                        return;
                    }
                    else
                    {
                        DialogResult Resultados = MessageBox.Show("Seguro desea eliminar el producto", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Resultados == DialogResult.Yes)
                        {
                            Producto.id_Productos = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                            Productos.EliminarProducto(Producto);
                            CargarDatos();
                        }
                    }
                
                }
                catch (Exception ex)
                {
                    DialogResult Resultados = MessageBox.Show("Debe seleccionar un registro para eliminar","Eliminar Producto",MessageBoxButtons.OK);
                    Producto.id_Productos = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    Productos.EliminarProducto(Producto);
                    CargarDatos();
                }
                
            }
                
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {


                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("", "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (dataGridView1.SelectedRows == null)
                    {
                        return;
                    }
                    else
                    {
                        FormEditarProducto EditarProducto = new FormEditarProducto(this);
                        EditarProducto.UpdateEventHandler += EdPro_UpdateEventHandler;
                        EditarProducto.txtId_Producto.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        EditarProducto.TxtCodProd.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        EditarProducto.TxtNombrProd.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        EditarProducto.txtDescProducto.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                        EditarProducto.txtPresentacion.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                        EditarProducto.txtCostoUnit.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                        EditarProducto.txtPrecioVta.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                        EditarProducto.CbTipoCargo.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                        EditarProducto.ShowDialog();
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Debe seleccionar un registro porfavor", "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void cboTipoBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LlenarComboBox()
        {
            cboProductos.DataSource = dataGridView1.Columns["Nombre"];
            cboProductos.DisplayMember = "Nombre de Producto";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
        {
            try
                {
                    foreach (DataGridViewRow Row in dataGridView1.Rows)
                    {
                            
                        
                            Producto.Cantidad = Convert.ToInt32(TxtBuscarProducto.Text.Trim());
                            Productos.EditarCantProductos(Producto);
                            MessageBox.Show("El producto se ha editado correctamente", "Editar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            EditaCant();
                            CargarDatos();
                        
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El producto no fue editado por: " + ex.Message, "Editar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
    }
}
