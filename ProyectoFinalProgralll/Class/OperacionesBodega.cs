using ProyectoFinalProgralll.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgralll.Class
{
    public class OperacionesBodega : IBodega
    {
        public void BuscarBodega(string nombre)
        {
            throw new NotImplementedException();
        }

        public void BuscarBodega(string nombre, int estado)
        {
            throw new NotImplementedException();
        }

        public void CrearBodega(Bodega bodega)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Server=OSMANC-777\\SQLEXPRESS;Database=AltoValirio;Trusted_Connection=true";
                    conn.Open();
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO Bodega VALUES (@Nombre,@Direccion,@Estado)", conn);

                    insertCommand.Parameters.Add(new SqlParameter("Nombre", bodega.Nombre));
                    insertCommand.Parameters.Add(new SqlParameter("Direccion", bodega.Direccion));
                    insertCommand.Parameters.Add(new SqlParameter("Estado", bodega.Estado));
                    insertCommand.ExecuteScalar();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void EditarBodega(int id)
        {
            throw new NotImplementedException();
        }

        public void EliminarBodega(int id)
        {
            throw new NotImplementedException();
        }

        public void EliminarBodega(int id, int estado)
        {
            throw new NotImplementedException();
        }
    }
}
