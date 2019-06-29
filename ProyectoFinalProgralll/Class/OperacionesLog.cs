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
    public class OperacionesLog : ILog
    {
        public DataSet ObtenerLogs()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Server=OSMANC-777\\SQLEXPRESS;Database=AltoValirio;Trusted_Connection=true";
                    conn.Open();

                    var select = "SELECT Usuarios.Nombre, Usuarios.Apellido, Log.TipoOperacion,Productos.Nombre as 'Producto'," +
                        "Categoria.Nombre as 'Categoria',  Marca.Nombre as 'Marca', Productos.Precio FROM Log " +
                        "INNER JOIN Usuarios ON Log.Id_usuario = Usuarios.Id " +
                        "INNER JOIN Productos ON Log.Id_producto = Productos.Id " +
                        "INNER JOIN Categoria ON Productos.Id_categoria = Categoria.Id " +
                        "INNER JOIN Marca ON Productos.Id_marca = Marca.Id";

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

        public void RegistroLog(Log log)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Server=OSMANC-777\\SQLEXPRESS;Database=AltoValirio;Trusted_Connection=true";
                    conn.Open();
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO Log VALUES (@Id_usuario,@Id_producto,@TipoOperacion,@Fecha)", conn);

                    insertCommand.Parameters.Add(new SqlParameter("Id_usuario", log.Id_usuario));
                    insertCommand.Parameters.Add(new SqlParameter("Id_producto", log.Id_producto));
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
