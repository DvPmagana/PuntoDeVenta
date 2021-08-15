using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaDominio
{
    public class CDO_Productos
    {
        CD_Productos ObjProductos = new CD_Productos();

        //Metodo que permite agregar un producto a la BD
        public void AgregarProducto(CE_Productos Productos)
        {
            ObjProductos.AgregarProducto(Productos);
        }
        public void EditarProducto(CE_Productos Productos)
        {
            ObjProductos.EditarProducto(Productos);
        }
        public void EliminarProducto(CE_Productos Productos)
        {
            ObjProductos.EliminarProducto(Productos);
        }
        public void EditarCantProductos(CE_Productos Productos)
        {
            ObjProductos.EditarCantProducto(Productos);
        }

    }
}
