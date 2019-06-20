using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgralll.Class
{
    public class Login
    {

        public DataSet LoginUsuario(string correo, string contrasenia)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {

                    conn.ConnectionString = "Server=localhost\\SQLEXPRESS;Database=AltoValirio;Trusted_Connection=true";
                    conn.Open();

                    var select = "SELECT * FROM Usuarios WHERE Correo ='" + correo + "' AND Contrasenia ='" + contrasenia + "'";
                    var dataAdapter = new SqlDataAdapter(select, conn);
                    var commandBuilder = new SqlCommandBuilder(dataAdapter);
                    var ds = new DataSet();

                    dataAdapter.Fill(ds);
                    return ds;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
