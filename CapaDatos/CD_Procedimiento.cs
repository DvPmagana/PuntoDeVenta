using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CD_Procedimiento
    {
        CD_Conexion Con = new CD_Conexion();

        SqlCommand Cmd;
        SqlDataReader Dr;
        DataTable Dt;  


        //Metodo que me permite cargar los datos de una tabla a un DataGridView
        public DataTable CargarDatos(string Tabla)
        {
            Dt = new DataTable("Cargar Datos");
            Cmd = new SqlCommand("Select * Form "+Tabla, Con.Abrir());
            Cmd.CommandType = CommandType.Text;

            Dr = Cmd.ExecuteReader();
            Dt.Load(Dr);
            Dr.Close();
            
            Con.Cerrar();
            return Dt;
        }
        public void AlternarColorFilaDataGridView(DataGridView Dgv)
        {
            Dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            Dgv.DefaultCellStyle.BackColor = Color.White;
        }
        public String GenerarCodigo(string Tabla)
        {
            string Codigo = string.Empty;
            int Total = 0;

            Cmd = new SqlCommand("Select (*) as TotalResgistros From " + Tabla, Con.Abrir());
            Cmd = new SqlCommand("Select * Form " + Tabla, Con.Abrir());
            Cmd.CommandType = CommandType.Text;

            Dr = Cmd.ExecuteReader();
            if (Dr.Read())
            {
                Total = Convert.ToInt32(Dr["TotalRegistros"]) + 1;
            }
            Dr.Close();

            if (Total < 10)
            {
                Codigo = "00000000" + Total;
            }
            else if (Total < 100)
            {
                Codigo = "0000000" + Total;
            }
            else if (Total < 1000)
            {
                Codigo = "00000" + Total;
            }
            else if (Total < 10000)
            {
                Codigo = "0000" + Total;
            }
            else if (Total < 1000000)
            {
                Codigo = "00" + Total;
            }
            else if (Total < 10000000)
            {
                Codigo = "0" + Total;
            }
            Con.Cerrar();
            return Codigo;
        }
        public String GenerarCodigoId(string Tabla)
        {
            string Codigo = string.Empty;
            int Total = 0;

            Cmd = new SqlCommand("Select (*) as TotalResgistros From " + Tabla, Con.Abrir());
            Cmd = new SqlCommand("Select * Form " + Tabla, Con.Abrir());
            Cmd.CommandType = CommandType.Text;

            Dr = Cmd.ExecuteReader();
            if (Dr.Read())
            {
                Total = Convert.ToInt32(Dr["TotalRegistros"]) + 1;
            }
            Dr.Close();

            Con.Cerrar();
            return Codigo;
        }

        //Metodo que permite dar formato moneda a un TextBox o Caja de Texto
        public void FomratoMoneda(TextBox xTbox)
        {
            if (xTbox.Text == string.Empty)
            {
                return;
            }
            else
            {
                decimal Monto;
                Monto = Convert.ToDecimal(xTbox.Text);
                xTbox.Text = Monto.ToString("N2");
            }
        }
        //Metodo que permite dar formato moneda a un TextBox o Caja de Texto
        public void LimpiarControles(TextBox xForm)
        {
            foreach(var xCtrl in xForm.Controls)
            {
                if(xCtrl is TextBox)
                {
                    ((TextBox)xCtrl).Text = string.Empty;
                }
                else if (xCtrl is TextBox)
                {
                    ((ComboBox)xCtrl).Text = string.Empty;
                }
            }
        }
        public void LlenarComboBox(string Tabla, string Nombre, ComboBox xCbox)
        {
            Cmd = new SqlCommand("Select * From " + Tabla, Con.Abrir());
            Cmd.CommandType = CommandType.Text;

            Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {
                xCbox.Items.Add(Dr[Nombre].ToString());
            }
        }

    }
}
