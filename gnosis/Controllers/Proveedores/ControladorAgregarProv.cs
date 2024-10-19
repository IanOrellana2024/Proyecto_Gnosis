using gnosis.Models.DAO;
using gnosis.Views.Proveedores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gnosis.Controllers.Proveedores
{
    internal class ControladorAgregarProv
    {

        AgregarProveedor AgregarProv;

        public ControladorAgregarProv(AgregarProveedor vista)
        {
            AgregarProv = vista;

            AgregarProv.btnGuardarAlmacenamiento.Click += new EventHandler(Agregar);

        }

        public void Agregar(object sender, EventArgs e)
        {
            DAOAgregarProv dAOAgregarProv = new DAOAgregarProv();

            dAOAgregarProv.Nombre = AgregarProv.txtNombre.Text;
            dAOAgregarProv.Telefono = AgregarProv.txtTelefono.Text;
            dAOAgregarProv.Direccion = AgregarProv.txtDireccion.Text;
            dAOAgregarProv.Codigo = AgregarProv.txtCodigo.Text;
            dAOAgregarProv.Correo = AgregarProv.txtEmail.Text;
            dAOAgregarProv.Comentario = AgregarProv.txtComentario.Text;
            if (AgregarProv.chActivo.Checked)
            {
                dAOAgregarProv.Estado = 1;
            }
            else
            {
                dAOAgregarProv.Estado = 0;
            }

            int respuesta = dAOAgregarProv.Insertar();

            if (respuesta == 1)
            {
                MessageBox.Show("Datos insertados correctamente");
                ProveedoresForm proveedores = new ProveedoresForm();
                proveedores.Refresh();
                AgregarProv.Close();

            }




        }
    }
}
