using ProyectoFinalProgralll.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgralll.Class
{
    public class OperacionesLogUsuario : IUsuarioLog
    {
        public DataSet ObtenerLogs()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Server=OSMANC-777\\SQLEXPRESS;Database=AltoValirio;Trusted_Connection=true";
                    conn.Open();

                    var select = "SELECT Usuarios.Nombre, Usuarios.Apellido, LogUsuarios.TipoOperacion  ,LogUsuarios.Fecha FROM LogUsuarios INNER JOIN Usuarios ON LogUsuarios.Id_usuario = Usuarios.Id";

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

        public void RegistroLog(LogUsuarios log)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Server=OSMANC-777\\SQLEXPRESS;Database=AltoValirio;Trusted_Connection=true";
                    conn.Open();
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO LogUsuarios VALUES (@Id_usuario,@TipoOperacion,@Fecha)", conn);

                    insertCommand.Parameters.Add(new SqlParameter("Id_usuario", log.Id_usuario));
                    insertCommand.Parameters.Add(new SqlParameter("TipoOperacion", log.TipoOperacion));
                    insertCommand.Parameters.Add(new SqlParameter("Fecha", log.Fecha));

                    insertCommand.ExecuteScalar();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
