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
    public class OperacionesUsuario : IUsuario
    {
        public DataSet BuscarUsuario(string correo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Server=OSMANC-777\\SQLEXPRESS;Database=AltoValirio;Trusted_Connection=true";
                    conn.Open();

                    var select = "SELECT * FROM Usuarios WHERE Correo ='"+ correo + "'";
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

        public DataSet BuscarUsuarioNombre(string nombre)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Server=OSMANC-777\\SQLEXPRESS;Database=AltoValirio;Trusted_Connection=true";
                    conn.Open();

                    var select = "SELECT * FROM Usuarios WHERE Nombre ='" + nombre + "'";
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

        public void CrearUsuario(Usuarios usuario)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Server=OSMANC-777\\SQLEXPRESS;Database=AltoValirio;Trusted_Connection=true";
                    conn.Open();
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO Usuarios VALUES (@Nombre,@Apellido,@Correo,@Contrasenia,@Id_bodega,@Id_rol)", conn);

                    insertCommand.Parameters.Add(new SqlParameter("Nombre", usuario.Nombre));
                    insertCommand.Parameters.Add(new SqlParameter("Apellido", usuario.Apellido));
                    insertCommand.Parameters.Add(new SqlParameter("Correo", usuario.Correo));
                    insertCommand.Parameters.Add(new SqlParameter("Contrasenia", usuario.Contrasenia));
                    insertCommand.Parameters.Add(new SqlParameter("Id_bodega", usuario.Id_bodega));
                    insertCommand.Parameters.Add(new SqlParameter("Id_rol", usuario.Id_rol));
                    insertCommand.ExecuteScalar();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void EditarUsuario(Usuarios usuario, int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Server=OSMANC-777\\SQLEXPRESS;Database=AltoValirio;Trusted_Connection=true";
                    conn.Open();

                    SqlCommand insertCommand = new SqlCommand("UPDATE Usuarios SET Nombre = @Nombre, Apellido = @Apellido, Correo = @Correo," +
                        "Contrasenia = @Contrasenia, Id_bodega = @Id_bodega, Id_rol = @Id_rol" +" WHERE Id = " + id, conn);

                    insertCommand.Parameters.Add(new SqlParameter("Nombre", usuario.Nombre));
                    insertCommand.Parameters.Add(new SqlParameter("Apellido", usuario.Apellido));
                    insertCommand.Parameters.Add(new SqlParameter("Correo", usuario.Correo));
                    insertCommand.Parameters.Add(new SqlParameter("Contrasenia", usuario.Contrasenia));
                    insertCommand.Parameters.Add(new SqlParameter("Id_bodega", usuario.Id_bodega));
                    insertCommand.Parameters.Add(new SqlParameter("Id_rol", usuario.Id_rol));
                    insertCommand.ExecuteScalar();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void EliminarUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public void EliminarUsuario(int id, int estado)
        {
            throw new NotImplementedException();
        }

        public DataSet ObtenerUsuarios()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Server=OSMANC-777\\SQLEXPRESS;Database=AltoValirio;Trusted_Connection=true";
                    conn.Open();

                    //var select = "SELECT * FROM Usuarios";
                    var select = "SELECT Usuarios.Nombre, Usuarios.Apellido, Usuarios.Correo, Bodega.Nombre as 'Bodega', Roles.Nombre as 'Rol' " +
                        "FROM Usuarios INNER JOIN Bodega ON Usuarios.Id_bodega = Bodega.id INNER JOIN Roles ON Usuarios.Id_rol = Roles.id";
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
