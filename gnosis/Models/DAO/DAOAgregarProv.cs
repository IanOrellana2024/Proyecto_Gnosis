using gnosis.Models.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gnosis.Models.DAO
{
    internal class DAOAgregarProv : DTOAgregarProv
    {

        readonly SqlCommand command = new SqlCommand();

        public int Insertar()
        {

            try
            {

                command.Connection = getConnection();

                string query = "Insert Into tbProvider Values(@param1, @param2, @param3, @param4, @param5, @param6, @param7)";

                SqlCommand cmd = new SqlCommand(query, command.Connection);

                cmd.Parameters.AddWithValue("@param1", Nombre);
                cmd.Parameters.AddWithValue("@param2", Telefono);
                cmd.Parameters.AddWithValue("@param3", Direccion);
                cmd.Parameters.AddWithValue("@param4", Correo);
                cmd.Parameters.AddWithValue("@param5", Codigo);
                cmd.Parameters.AddWithValue("@param6", Estado);
                cmd.Parameters.AddWithValue("@param7", Comentario);

                int respuesta = cmd.ExecuteNonQuery();

                return respuesta;

            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK);
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }

        }


    }
}
