using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using gnosis.Models.DAO;
using gnosis.Views.Proveedores;

namespace gnosis.Controllers.Proveedores
{
    internal class ControladorProv
    {

        ProveedoresForm Proveedores;

        public ControladorProv(ProveedoresForm vista) {

            this.Proveedores = vista;

            Proveedores.Load += new EventHandler(Cargar);
            Proveedores.Eliminar.Click += new EventHandler(Eliminar);
            Proveedores.Agregar.Click += new EventHandler(Agregar);
            Proveedores.Actualizar.Click += new EventHandler(Actualizar);
            Proveedores.txtbuscar.KeyPress += new KeyPressEventHandler(buscar);
        }

        public void Cargar(object sender, EventArgs e)
        {
            Refresh();

        }


        public void Refresh()
        {
            DAOProv dAOProv = new DAOProv();

            DataSet respuesta = dAOProv.Cargar();

            Proveedores.DgvProveedores.DataSource = respuesta.Tables["tbProvider"];

        }

        public void Eliminar(object sender, EventArgs e)
        {
            DAOProv dAOProv = new DAOProv();

            int pos = Proveedores.DgvProveedores.CurrentRow.Index;

            dAOProv.Id = int.Parse(Proveedores.DgvProveedores[0, pos].Value.ToString());

            int respuesta = dAOProv.eliminar();

            if (respuesta == 1) {
                MessageBox.Show("Los datos se eliminaron correctamente", "Datos eliminados");
            }
            Refresh();

        }


        public void Agregar(object sender, EventArgs e)
        {
            AgregarProveedor Agregar = new AgregarProveedor();

            Agregar.ShowDialog();

            Refresh();
        }

        public void Actualizar(object sender, EventArgs e)
        {
            int pos = Proveedores.DgvProveedores.CurrentRow.Index;

            int id = int.Parse(Proveedores.DgvProveedores[0, pos].Value.ToString());
            string nombre = Proveedores.DgvProveedores[1, pos].Value.ToString();
            string telefono = Proveedores.DgvProveedores[2, pos].Value.ToString();
            string direccion = Proveedores.DgvProveedores[3, pos].Value.ToString();
            string correo = Proveedores.DgvProveedores[4, pos].Value.ToString();
            string codigo = Proveedores.DgvProveedores[5, pos].Value.ToString();
            bool estado = Convert.ToBoolean(Proveedores.DgvProveedores[6, pos].Value);
            string comentario = Proveedores.DgvProveedores[7, pos].Value.ToString();

            ActualizarProvForm Actualizar = new ActualizarProvForm(id, nombre, telefono, direccion, correo, codigo, estado, comentario);
            Actualizar.ShowDialog();

        }


        public void buscar(object sender, EventArgs e)
        {
            DAOProv dAOProv = new DAOProv();

            dAOProv.Buscar1 = Proveedores.txtbuscar.Text;

            string consulta = dAOProv.Buscar1;

            DataSet respuesta = dAOProv.Buscar(consulta);

            Proveedores.DgvProveedores.DataSource = respuesta.Tables["tbProvider"];

        }

    }
}
