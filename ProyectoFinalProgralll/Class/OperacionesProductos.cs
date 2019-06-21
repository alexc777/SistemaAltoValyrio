using ProyectoFinalProgralll.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgralll.Class
{
    public class OperacionesProductos : IProducto
    {
        public void BuscarProducto(string nombre)
        {
            throw new NotImplementedException();
        }

        public void BuscarProducto(string nombre, int estado)
        {
            throw new NotImplementedException();
        }

        public int idProdCrate = 0;
        public void CrearProducto(Productos producto)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Server=OSMANC-777\\SQLEXPRESS;Database=AltoValirio;Trusted_Connection=true";
                    conn.Open();
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO Productos VALUES (@Nombre,@Precio,@Id_marca,@Id_categoria" +
                        ",@Refrigerado,@Fecha_vence,@TipoEmpaque,@Fecha_creo,@Cantidad) SELECT SCOPE_IDENTITY()", conn);

                    insertCommand.Parameters.Add(new SqlParameter("Nombre", producto.Nombre));
                    insertCommand.Parameters.Add(new SqlParameter("Precio", producto.Precio));
                    insertCommand.Parameters.Add(new SqlParameter("Id_marca", producto.Id_marca));
                    insertCommand.Parameters.Add(new SqlParameter("Id_categoria", producto.Id_categoria));
                    insertCommand.Parameters.Add(new SqlParameter("Refrigerado", producto.Refrigerado));
                    insertCommand.Parameters.Add(new SqlParameter("Fecha_vence", producto.Fecha_vence));
                    insertCommand.Parameters.Add(new SqlParameter("TipoEmpaque", producto.TipoEmpaque));
                    insertCommand.Parameters.Add(new SqlParameter("Fecha_creo", producto.Fecha_creo));
                    insertCommand.Parameters.Add(new SqlParameter("Cantidad", producto.Cantidad));

                    idProdCrate = Convert.ToInt32(insertCommand.ExecuteScalar());
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void EditarProducto(int id)
        {
            throw new NotImplementedException();
        }

        public void EliminarProducto(int id)
        {
            throw new NotImplementedException();
        }

        public void GuardarHubiProducto(HubicacionProducto producto)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Server=OSMANC-777\\SQLEXPRESS;Database=AltoValirio;Trusted_Connection=true";
                    conn.Open();
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO HubicacionProducto VALUES (@Id_producto,@Id_bodega,@Fecha)", conn);

                    insertCommand.Parameters.Add(new SqlParameter("Id_producto", producto.Id_producto));
                    insertCommand.Parameters.Add(new SqlParameter("Id_bodega", producto.Id_bodega));
                    insertCommand.Parameters.Add(new SqlParameter("Fecha", producto.Fecha));

                    insertCommand.ExecuteScalar();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void BuscarHubiProducto(string nombre)
        {
            throw new NotImplementedException();
        }

        public void BuscarHubiProducto(string nombre, int estado)
        {
            throw new NotImplementedException();
        }

        public void ActualizarHubiProducto(HubicacionProducto producto)
        {
            throw new NotImplementedException();
        }

        public void ElimiHubinarProducto(int id)
        {
            throw new NotImplementedException();
        }
    }
}
