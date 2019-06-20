using ProyectoFinalProgralll.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgralll.Class
{
    public class OperacionesMarcaCategoria : IMarcaCategoria
    {
        public void BuscarCategoria(string nombre)
        {
            throw new NotImplementedException();
        }

        public void BuscarCategoria(string nombre, int estado)
        {
            throw new NotImplementedException();
        }

        public void BuscarMarca(string nombre)
        {
            throw new NotImplementedException();
        }

        public void BuscarMarca(string nombre, int estado)
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

        public void EditarCategoria(int id)
        {
            throw new NotImplementedException();
        }

        public void EditarMarca(int id)
        {
            throw new NotImplementedException();
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
    }
}
