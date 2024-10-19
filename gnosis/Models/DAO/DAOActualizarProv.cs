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
    internal class DAOActualizarProv : DTOActualizarProv
    {

        readonly SqlCommand command = new SqlCommand();

        public int Actualizar()
        {
            try
            {
                command.Connection = getConnection();

                string query = "UPDATE tbProvider SET providerName = @param2, providerPhone = @param3, providerAddress = @param4, providerEmail = @param5, providerCode = @param6, providerStatus = @param7, providerComments = @param8 WHERE providerID = @param1";

                SqlCommand cmd = new SqlCommand(query, command.Connection);

                cmd.Parameters.AddWithValue("@param1", Id);
                cmd.Parameters.AddWithValue("@param2", Nombre);
                cmd.Parameters.AddWithValue("@param3", Telefono);
                cmd.Parameters.AddWithValue("@param4", Direccion);
                cmd.Parameters.AddWithValue("@param5", Correo);
                cmd.Parameters.AddWithValue("@param6", Codigo);
                cmd.Parameters.AddWithValue("@param7", Estado);
                cmd.Parameters.AddWithValue("@param8", Comentario);

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
