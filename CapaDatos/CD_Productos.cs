
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CD_Productos
    {
        CD_Conexion Con = new CD_Conexion();
        SqlCommand Cmd;
        //Metodo que agrega productos a BD
        public void AgregarProducto(CE_Productos Productos)
        {
            Cmd = new SqlCommand("AgregarProductos", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Codigo", Productos.Codigo));
            Cmd.Parameters.Add(new SqlParameter("@Nombre", Productos.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@Descripcion", Productos.Descripcion));
            Cmd.Parameters.Add(new SqlParameter("@Presentacion", Productos.Presentacion));
            Cmd.Parameters.Add(new SqlParameter("@Costo_Unitario", Productos.Costo_Unitario));
            Cmd.Parameters.Add(new SqlParameter("@Precio_Venta", Productos.Precio_Venta));
            Cmd.Parameters.Add(new SqlParameter("@Tipo_Cargo", Productos.Tipo_Cargo));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }
        public void EditarProducto(CE_Productos Productos)
        {
            Cmd = new SqlCommand("EditarProducto", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Codigo", Productos.Codigo));
            Cmd.Parameters.Add(new SqlParameter("@Nombre", Productos.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@Descripcion", Productos.Descripcion));
            Cmd.Parameters.Add(new SqlParameter("@Presentacion", Productos.Presentacion));
            Cmd.Parameters.Add(new SqlParameter("@Costo_Unitario", Productos.Costo_Unitario));
            Cmd.Parameters.Add(new SqlParameter("@Precio_Venta", Productos.Precio_Venta));
            Cmd.Parameters.Add(new SqlParameter("@Tipo_Cargo", Productos.Tipo_Cargo));
            Cmd.Parameters.Add(new SqlParameter("@id_Productos", Productos.id_Productos));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }
        public void EliminarProducto(CE_Productos Productos)
        {
            int Existencia = 0;

            Cmd = new SqlCommand("Select Cantidad From Inventario Where id_Inventario=" + Productos.id_Productos + "", Con.Abrir());
            Cmd.CommandType = CommandType.Text;

            SqlDataReader Dr = Cmd.ExecuteReader();
            if (Dr.Read())
            {
                Existencia = Convert.ToInt32(Dr["Cantidad"].ToString());
            }
            Dr.Close();

            if (Existencia != 0)
            {
                MessageBox.Show("El Producto contiene existencia, no puede ser eliminado", "EliminarProducto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Cmd = new SqlCommand("EliminarProducto", Con.Abrir());
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@id_Productos", Productos.id_Productos));
                Cmd.ExecuteNonQuery();
                MessageBox.Show("El Producto fue Eliminado", "EliminarProducto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Con.Cerrar();
            }
        }
    }
}
