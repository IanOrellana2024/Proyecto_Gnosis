using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gnosis.Controllers;
using gnosis.Controllers.Proveedores;

namespace gnosis.Views.Proveedores
{
    public partial class ActualizarProvForm : Form
    {
        public ActualizarProvForm(int id, string nombre, string telefono, string direccion, string correo, string codigo, bool estado, string comentario)
        {
            InitializeComponent();
            ControladorActualizarProv Actualizar = new ControladorActualizarProv(this, id, nombre, telefono, direccion, correo, codigo, estado, comentario);
        }

    }
}
