using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using CapaDatos;

namespace CapaDominio
{
    public class CDO_Procedimientos
    {
        CD_Procedimiento ObjProcedimientos = new CD_Procedimiento();
       
        public DataTable CargarDatos(string Tabla)
        {
            return ObjProcedimientos.CargarDatos(Tabla);
        }

        public void AlternarColorFilaDataGridView(DataGridView Dgv)
        {
            ObjProcedimientos.AlternarColorFilaDataGridView(Dgv);

        }
        public String GenerarCodigo(string Tabla)
        {
            return ObjProcedimientos.GenerarCodigo(Tabla);
        }
        public String GenerarCodigoId(string Tabla)
        {
            return ObjProcedimientos.GenerarCodigoId(Tabla);
        }

        //Metodo que permite dar formato moneda a un TextBox o Caja de Texto
        public void FomratoMoneda(TextBox xTbox)
        {
            ObjProcedimientos.FomratoMoneda(xTbox);
        }
        //Metodo que permite dar formato moneda a un TextBox o Caja de Texto
        public void LimpiarControles(TextBox xForm)
        {
            ObjProcedimientos.LimpiarControles(xForm);
        }
        public void LlenarComboBox(string Tabla, string Nombre, ComboBox xCbox)
        {
            ObjProcedimientos.LlenarComboBox(Tabla, Nombre, xCbox);
        }
    }

}
