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
    public class OperacionesProductos : IProducto
    {
        public void ActualizarProductoTraslado(int idProducto, int Cantidad)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Server=OSMANC-777\\SQLEXPRESS;Database=AltoValirio;Trusted_Connection=true";
                    conn.Open();

                    SqlCommand insertCommand = new SqlCommand("UPDATE Productos SET Cantidad = "+ Cantidad +"WHERE Id = "+ idProducto, conn);

                    insertCommand.Parameters.Add(new SqlParameter("Cantidad", Cantidad));
                    insertCommand.ExecuteScalar();
                    
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void BuscarProducto(string nombre)
        {
            throw new NotImplementedException();
        }

        public void BuscarProducto(string nombre, int estado)
        {
            throw new NotImplementedException();
        }

        public void CrearProducto(Productos producto)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Server=OSMANC-777\\SQLEXPRESS;Database=AltoValirio;Trusted_Connection=true";
                    conn.Open();
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO Productos VALUES (@Nombre,@Precio,@Id_marca,@Id_categoria" +
                        ",@Refrigerado,@TipoEmpaque,@Cantidad,@Estado,@Fecha_vence,@Fecha_creo)", conn);

                    insertCommand.Parameters.Add(new SqlParameter("Nombre", producto.Nombre));
                    insertCommand.Parameters.Add(new SqlParameter("Precio", producto.Precio));
                    insertCommand.Parameters.Add(new SqlParameter("Id_marca", producto.Id_marca));
                    insertCommand.Parameters.Add(new SqlParameter("Id_categoria", producto.Id_categoria));
                    insertCommand.Parameters.Add(new SqlParameter("Refrigerado", producto.Refrigerado));
                    insertCommand.Parameters.Add(new SqlParameter("TipoEmpaque", producto.TipoEmpaque));
                    insertCommand.Parameters.Add(new SqlParameter("Cantidad", producto.Cantidad));
                    insertCommand.Parameters.Add(new SqlParameter("Estado", producto.Estado));
                    insertCommand.Parameters.Add(new SqlParameter("Fecha_vence", producto.Fecha_vence));
                    insertCommand.Parameters.Add(new SqlParameter("Fecha_creo", producto.Fecha_creo));
                    insertCommand.ExecuteScalar();

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

        public DataSet ProductoCategoria(int Id_categoria)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Server=OSMANC-777\\SQLEXPRESS;Database=AltoValirio;Trusted_Connection=true";
                    conn.Open();

                    var select = "SELECT * FROM Productos WHERE Productos.Id_categoria = " + Id_categoria + " AND Productos.Estado ="+ 1 + "ORDER BY Productos.Fecha_creo DESC";
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

        public void RegistroBitacora(Vitacora bitacora)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Server=OSMANC-777\\SQLEXPRESS;Database=AltoValirio;Trusted_Connection=true";
                    conn.Open();
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO Vitacora VALUES (@Id_usuario,@Tipo_operacion,@Fecha,@Id_productoBodega)", conn);

                    insertCommand.Parameters.Add(new SqlParameter("Id_usuario", bitacora.Id_usuario));
                    insertCommand.Parameters.Add(new SqlParameter("Tipo_operacion", bitacora.Tipo_operacion));
                    insertCommand.Parameters.Add(new SqlParameter("Fecha", bitacora.Fecha));
                    insertCommand.Parameters.Add(new SqlParameter("Id_productoBodega", bitacora.Id_productoBodega));

                    insertCommand.ExecuteScalar();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int IdTraslado = 0;
        public void TrasladarProducto(ProductoBodega productoBodega)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Server=OSMANC-777\\SQLEXPRESS;Database=AltoValirio;Trusted_Connection=true";
                    conn.Open();
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO ProductoBodega VALUES (@Id_producto,@Id_bodega,@Cantidad_inicial,@Cantidad_actual) SELECT SCOPE_IDENTITY()", conn);

                    insertCommand.Parameters.Add(new SqlParameter("Id_producto", productoBodega.Id_producto));
                    insertCommand.Parameters.Add(new SqlParameter("Id_bodega", productoBodega.Id_bodega));
                    insertCommand.Parameters.Add(new SqlParameter("Cantidad_inicial", productoBodega.Cantidad_inicial));
                    insertCommand.Parameters.Add(new SqlParameter("Cantidad_actual", productoBodega.Cantidad_actual));

                    IdTraslado = Convert.ToInt32(insertCommand.ExecuteScalar());
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
