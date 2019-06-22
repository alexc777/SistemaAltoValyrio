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
    public class OperacionesReportes : IReportes
    {
        public DataSet ObtenerProductos()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Server=OSMANC-777\\SQLEXPRESS;Database=AltoValirio;Trusted_Connection=true";
                    conn.Open();

                    var select = "SELECT Productos.Nombre as 'Producto', Productos.Precio as 'Precio Producto', Marca.Nombre as 'Marca', " +
                        "Categoria.Nombre as 'Categoria', Empaque.Tipo as 'Empaque', ProductoBodega.Cantidad_inicial as 'Cantidad Ingreso'," +
                        "ProductoBodega.Cantidad_actual as 'Cantidad Actual', Bodega.Nombre as 'Bodega', " +
                        "Bodega.Direccion as 'Direccion Bodega', Vitacora.Fecha FROM Vitacora " +
                        "INNER JOIN Usuarios ON Vitacora.Id_usuario = Usuarios.Id " +
                        "INNER JOIN ProductoBodega ON Vitacora.Id_productoBodega = ProductoBodega.Id " +
                        "INNER JOIN Bodega ON ProductoBodega.Id_bodega = Bodega.Id " +
                        "INNER JOIN Productos ON ProductoBodega.Id_producto = Productos.Id " +
                        "INNER JOIN Marca ON Productos.Id_marca = Marca.Id " +
                        "INNER JOIN Categoria ON Productos.Id_categoria = Categoria.Id " +
                        "INNER JOIN Empaque ON Productos.TipoEmpaque = Empaque.Id " +
                        "WHERE Productos.Estado = 1";


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

        public DataSet ObtenerProductos(int Id_bodega)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Server=OSMANC-777\\SQLEXPRESS;Database=AltoValirio;Trusted_Connection=true";
                    conn.Open();

                    var select = "SELECT Productos.Nombre as 'Producto', Productos.Precio as 'Precio Producto', Marca.Nombre as 'Marca', " +
                        "Categoria.Nombre as 'Categoria', Empaque.Tipo as 'Empaque', ProductoBodega.Cantidad_inicial as 'Cantidad Ingreso'," +
                        "ProductoBodega.Cantidad_actual as 'Cantidad Actual', Bodega.Nombre as 'Bodega', " +
                        "Bodega.Direccion as 'Direccion Bodega', Vitacora.Fecha FROM Vitacora " +
                        "INNER JOIN Usuarios ON Vitacora.Id_usuario = Usuarios.Id " +
                        "INNER JOIN ProductoBodega ON Vitacora.Id_productoBodega = ProductoBodega.Id " +
                        "INNER JOIN Bodega ON ProductoBodega.Id_bodega = Bodega.Id " +
                        "INNER JOIN Productos ON ProductoBodega.Id_producto = Productos.Id " +
                        "INNER JOIN Marca ON Productos.Id_marca = Marca.Id " +
                        "INNER JOIN Categoria ON Productos.Id_categoria = Categoria.Id " +
                        "INNER JOIN Empaque ON Productos.TipoEmpaque = Empaque.Id " +
                        "WHERE Productos.Estado = 1 AND Bodega.Id = " + Id_bodega;


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

        public DataSet ObtenerProductosCategorias(int Id_categoria)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Server=OSMANC-777\\SQLEXPRESS;Database=AltoValirio;Trusted_Connection=true";
                    conn.Open();

                    var select = "SELECT Productos.Nombre as 'Producto', Productos.Precio as 'Precio Producto', Marca.Nombre as 'Marca', " +
                        "Categoria.Nombre as 'Categoria', Empaque.Tipo as 'Empaque', ProductoBodega.Cantidad_inicial as 'Cantidad Ingreso'," +
                        "ProductoBodega.Cantidad_actual as 'Cantidad Actual', Bodega.Nombre as 'Bodega', " +
                        "Bodega.Direccion as 'Direccion Bodega', Vitacora.Fecha FROM Vitacora " +
                        "INNER JOIN Usuarios ON Vitacora.Id_usuario = Usuarios.Id " +
                        "INNER JOIN ProductoBodega ON Vitacora.Id_productoBodega = ProductoBodega.Id " +
                        "INNER JOIN Bodega ON ProductoBodega.Id_bodega = Bodega.Id " +
                        "INNER JOIN Productos ON ProductoBodega.Id_producto = Productos.Id " +
                        "INNER JOIN Marca ON Productos.Id_marca = Marca.Id " +
                        "INNER JOIN Categoria ON Productos.Id_categoria = Categoria.Id " +
                        "INNER JOIN Empaque ON Productos.TipoEmpaque = Empaque.Id " +
                        "WHERE Productos.Estado = 1 AND Categoria.Id = " + Id_categoria;


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

        public DataSet ObtenerProductosMarca(int Id_marca)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Server=OSMANC-777\\SQLEXPRESS;Database=AltoValirio;Trusted_Connection=true";
                    conn.Open();

                    var select = "SELECT Productos.Nombre as 'Producto', Productos.Precio as 'Precio Producto', Marca.Nombre as 'Marca', " +
                        "Categoria.Nombre as 'Categoria', Empaque.Tipo as 'Empaque', ProductoBodega.Cantidad_inicial as 'Cantidad Ingreso'," +
                        "ProductoBodega.Cantidad_actual as 'Cantidad Actual', Bodega.Nombre as 'Bodega', " +
                        "Bodega.Direccion as 'Direccion Bodega', Vitacora.Fecha FROM Vitacora " +
                        "INNER JOIN Usuarios ON Vitacora.Id_usuario = Usuarios.Id " +
                        "INNER JOIN ProductoBodega ON Vitacora.Id_productoBodega = ProductoBodega.Id " +
                        "INNER JOIN Bodega ON ProductoBodega.Id_bodega = Bodega.Id " +
                        "INNER JOIN Productos ON ProductoBodega.Id_producto = Productos.Id " +
                        "INNER JOIN Marca ON Productos.Id_marca = Marca.Id " +
                        "INNER JOIN Categoria ON Productos.Id_categoria = Categoria.Id " +
                        "INNER JOIN Empaque ON Productos.TipoEmpaque = Empaque.Id " +
                        "WHERE Productos.Estado = 1 AND Marca.Id = " + Id_marca;


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

        public DataSet ObtenerProductos(int Id_marca, int Id_Categoria, int Id_bodega)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Server=OSMANC-777\\SQLEXPRESS;Database=AltoValirio;Trusted_Connection=true";
                    conn.Open();

                    var select = "SELECT Productos.Nombre as 'Producto', Productos.Precio as 'Precio Producto', Marca.Nombre as 'Marca', " +
                        "Categoria.Nombre as 'Categoria', Empaque.Tipo as 'Empaque', ProductoBodega.Cantidad_inicial as 'Cantidad Ingreso'," +
                        "ProductoBodega.Cantidad_actual as 'Cantidad Actual', Bodega.Nombre as 'Bodega', " +
                        "Bodega.Direccion as 'Direccion Bodega', Vitacora.Fecha FROM Vitacora " +
                        "INNER JOIN Usuarios ON Vitacora.Id_usuario = Usuarios.Id " +
                        "INNER JOIN ProductoBodega ON Vitacora.Id_productoBodega = ProductoBodega.Id " +
                        "INNER JOIN Bodega ON ProductoBodega.Id_bodega = Bodega.Id " +
                        "INNER JOIN Productos ON ProductoBodega.Id_producto = Productos.Id " +
                        "INNER JOIN Marca ON Productos.Id_marca = Marca.Id " +
                        "INNER JOIN Categoria ON Productos.Id_categoria = Categoria.Id " +
                        "INNER JOIN Empaque ON Productos.TipoEmpaque = Empaque.Id " +
                        "WHERE Productos.Estado = 1 AND Marca.Id = " + Id_marca + " AND Categoria.Id = " + Id_Categoria + 
                        " AND Bodega.Id = " + Id_bodega;


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
