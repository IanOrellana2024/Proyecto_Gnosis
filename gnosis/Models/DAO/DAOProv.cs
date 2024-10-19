using gnosis.Models.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gnosis.Models.DAO
{
    internal class DAOProv : DTOProv
    {

        readonly SqlCommand command = new SqlCommand();



        public DataSet Cargar()
        {

            try
            {
                command.Connection = getConnection();

                string query = "Select * From tbProvider";

                SqlCommand cmd = new SqlCommand(query, command.Connection);

                cmd.ExecuteNonQuery();

                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                adp.Fill(ds, "tbProvider");

                return ds;

            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK);
                return null;
            }
            finally
            {
                command.Connection.Close();
            }


        }


        public int eliminar (){

            try
            {
                command.Connection = getConnection();

                string query = "Delete From tbProvider Where providerID = @param1";

                SqlCommand cmd = new SqlCommand(query, command.Connection);

                cmd.Parameters.AddWithValue("@param1", Id);

                int respuesta = cmd.ExecuteNonQuery();

                return respuesta;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }



        }


        public DataSet Buscar(string consulta)
        {
            command.Connection = getConnection();

            string query = "SELECT * FROM tbProvider WHERE providerName LIKE @consulta OR providerPhone LIKE @consulta";

            SqlCommand cmd = new SqlCommand (query, command.Connection);

            cmd.Parameters.AddWithValue("@consulta", "%" + consulta + "%");

            cmd.ExecuteNonQuery();

            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            adp.Fill(ds, "tbProvider");

            return ds;
        }


    }
}
