using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gnosis.Models.DAO;
using gnosis.Models.DTO;
using gnosis.Views.Proveedores;

namespace gnosis.Controllers.Proveedores
{
    internal class ControladorActualizarProv
    {

        ActualizarProvForm ActualizarProv;

        public ControladorActualizarProv(ActualizarProvForm vista, int id, string nombre, string telefono, string direccion, string correo, string codigo, bool estado, string comentario)
        {
            ActualizarProv = vista;

            Cargar(id, nombre, telefono, direccion, correo, codigo, estado, comentario);
            ActualizarProv.btnActualizarAlmacenamiento.Click += new EventHandler(Actualizar);
        }




        public void Actualizar(object sender, EventArgs e)
        {

            DAOActualizarProv dAOActualizarProv = new DAOActualizarProv();
            dAOActualizarProv.Id = int.Parse(ActualizarProv.txtId.Text);
            dAOActualizarProv.Nombre = ActualizarProv.txtNombre.Text;
            dAOActualizarProv.Telefono = ActualizarProv.txtTelefono.Text;
            dAOActualizarProv.Direccion = ActualizarProv.txtDireccion.Text;
            dAOActualizarProv.Codigo = ActualizarProv.txtCodigo.Text;
            dAOActualizarProv.Correo = ActualizarProv.txtEmail.Text;
            dAOActualizarProv.Comentario = ActualizarProv.txtComentario.Text;

            if (ActualizarProv.chActivo.Checked)
            {
                dAOActualizarProv.Estado = 1;
            }
            else
            {
                dAOActualizarProv.Estado = 0;
            }

            int respuesta = dAOActualizarProv.Actualizar();
            if (respuesta == 1)
            {
                MessageBox.Show("Datos actualizados correctamente");
                ProveedoresForm proveedores = new ProveedoresForm();
                proveedores.Refresh();
                ActualizarProv.Close();

            }

        }



        public void Cargar(int id, string nombre, string telefono, string direccion, string correo, string codigo, bool estado, string comentario)
        {
            ActualizarProv.txtId.Text = id.ToString();
            ActualizarProv.txtNombre.Text = nombre;
            ActualizarProv.txtTelefono.Text = telefono;
            ActualizarProv.txtDireccion.Text = direccion;
            ActualizarProv.txtEmail.Text = correo;
            ActualizarProv.txtCodigo.Text = codigo;
            ActualizarProv.txtComentario.Text = comentario;

            if (estado == true) 
            {
                ActualizarProv.chActivo.Checked = true;
            }else if (estado == false) 
            {
                ActualizarProv.chInactivo.Checked = true;
            }
        }
    }
}
