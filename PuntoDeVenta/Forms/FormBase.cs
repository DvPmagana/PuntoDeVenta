using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta.Forms
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

        private void FormBase_Load(object sender, EventArgs e)
        {

        }

        public virtual bool Guardar()
        {
            return false;
        }
        public virtual void Editar()
        {

        }
        public virtual void EditaCant()
        {

        }
        public virtual void Eliminar()
        {

        }
        public virtual void Buscar()
        {

        }
    }
}
