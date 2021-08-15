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
    public partial class FormInventario : FormBase
    {
        public FormInventario()
        {
            InitializeComponent();
        }
        CDO_Procedimientos Procedimientos = new CDO_Procedimientos();
        public static double total;

        private void FormInventario_Load(object sender, EventArgs e)
        {
            CargarDatos();
            SumarInventario();
            dataGridView1.Columns[0].Visible = false;//Inventario
            dataGridView1.Columns[1].Width = 140;//codigo Producto
            dataGridView1.Columns[2].Width = 260;//Nombre del Producto
            dataGridView1.Columns[3].Width = 150;//Cantidad
            dataGridView1.Columns[4].Width = 150;//Costo Unitario
            dataGridView1.Columns[5].Width = 140;//Precio de Venta
            dataGridView1.Columns[6].Width = 140;//Monto Total
            dataGridView1.Columns[7].Width = 150;//Tipo de Cargo

            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Format = "#,##0.00";
            dataGridView1.Columns[5].DefaultCellStyle.Format = "#,##0.00";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "#,##0.00";

            Procedimientos.AlternarColorFilaDataGridView(dataGridView1);
            SumInventario();
        }
        private void CargarDatos()
        {
            dataGridView1.DataSource = Procedimientos.CargarDatos("Inventario");
            dataGridView1.ClearSelection();
        }
        private void SumarInventario()
        {
            total = 0;
            foreach(DataGridViewRow Row in dataGridView1.Rows)
            {
                total += Convert.ToDouble(Row.Cells[6].Value);
            }
            TxtMontoTotalInv.Text = total.ToString("N2");
        }
        public void SumInventario()
{
            double total = 0;
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                total += Convert.ToDouble(row.Cells["Costo_Unitario"].Value);

            }
            TxtMontoTotalInv.Text = "$" + string.Format("{0:N2}", total);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtMontoTotalInv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
