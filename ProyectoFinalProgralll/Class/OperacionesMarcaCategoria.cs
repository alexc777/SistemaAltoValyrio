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
    public class OperacionesMarcaCategoria : IMarcaCategoria
    {
        public DataSet BuscarCategoria(string nombre)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Server=OSMANC-777\\SQLEXPRESS;Database=AltoValirio;Trusted_Connection=true";
                    conn.Open();

                    var select = "SELECT * FROM Categoria WHERE Nombre ='" + nombre + "'";
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

        public DataSet BuscarCategoria(string nombre, int estado)
        {
            throw new NotImplementedException();
        }

        public DataSet BuscarMarca(string nombre)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Server=OSMANC-777\\SQLEXPRESS;Database=AltoValirio;Trusted_Connection=true";
                    conn.Open();

                    var select = "SELECT * FROM Marca WHERE Nombre ='" + nombre + "'";
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

        public DataSet BuscarMarca(string nombre, int estado)
        {
            throw new NotImplementedException();
        }

        public void CrearCategoria(Categoria categoria)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Server=OSMANC-777\\SQLEXPRESS;Database=AltoValirio;Trusted_Connection=true";
                    conn.Open();
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO Categoria VALUES (@Nombre,@Estado)", conn);

                    insertCommand.Parameters.Add(new SqlParameter("Nombre", categoria.Nombre));
                    insertCommand.Parameters.Add(new SqlParameter("Estado", categoria.Estado));
                    insertCommand.ExecuteScalar();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CrearMarca(Marca marca)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Server=OSMANC-777\\SQLEXPRESS;Database=AltoValirio;Trusted_Connection=true";
                    conn.Open();
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO Marca VALUES (@Nombre,@Estado)", conn);

                    insertCommand.Parameters.Add(new SqlParameter("Nombre", marca.Nombre));
                    insertCommand.Parameters.Add(new SqlParameter("Estado", marca.Estado));
                    insertCommand.ExecuteScalar();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void EditarCategoria(Categoria categoria, int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Server=OSMANC-777\\SQLEXPRESS;Database=AltoValirio;Trusted_Connection=true";
                    conn.Open();

                    SqlCommand insertCommand = new SqlCommand("UPDATE Categoria SET Nombre = @Nombre WHERE Id = " + id, conn);

                    insertCommand.Parameters.Add(new SqlParameter("Nombre", categoria.Nombre));
                    insertCommand.ExecuteScalar();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void EditarMarca(Marca marca,int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Server=OSMANC-777\\SQLEXPRESS;Database=AltoValirio;Trusted_Connection=true";
                    conn.Open();

                    SqlCommand insertCommand = new SqlCommand("UPDATE Marca SET Nombre = @Nombre WHERE Id = " + id, conn);

                    insertCommand.Parameters.Add(new SqlParameter("Nombre", marca.Nombre));
                    insertCommand.ExecuteScalar();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void EliminarCategoria(int id)
        {
            throw new NotImplementedException();
        }

        public void EliminarCategoria(int id, int estado)
        {
            throw new NotImplementedException();
        }

        public void EliminarMarca(int id)
        {
            throw new NotImplementedException();
        }

        public void EliminarMarca(int id, int estado)
        {
            throw new NotImplementedException();
        }

        public DataSet ObtenerMarcas()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Server=OSMANC-777\\SQLEXPRESS;Database=AltoValirio;Trusted_Connection=true";
                    conn.Open();

                    //var select = "SELECT * FROM Usuarios";
                    var select = "SELECT * FROM Marca";
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

        public DataSet ObtenerCategorias()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Server=OSMANC-777\\SQLEXPRESS;Database=AltoValirio;Trusted_Connection=true";
                    conn.Open();

                    //var select = "SELECT * FROM Usuarios";
                    var select = "SELECT * FROM Categoria";
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
