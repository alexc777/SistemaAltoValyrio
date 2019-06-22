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
    public class OperacionesBitacora : IBitacora
    {
        public DataSet ObtenerMovimientos()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Server=OSMANC-777\\SQLEXPRESS;Database=AltoValirio;Trusted_Connection=true";
                    conn.Open();

                    var select = "SELECT Usuarios.Nombre, Usuarios.Apellido, Productos.Nombre as 'Producto', " +
                        "ProductoBodega.Cantidad_inicial as 'Cantidad Ingreso', ProductoBodega.Cantidad_actual as 'Cantidad Actual', " +
                        "Bodega.Nombre as 'Bodega', Bodega.Direccion as 'Direccion Bodega', Vitacora.Tipo_operacion as 'Tipo Operacion', " +
                        "Vitacora.Fecha FROM Vitacora INNER JOIN Usuarios ON Vitacora.Id_usuario = Usuarios.Id " +
                        "INNER JOIN ProductoBodega ON Vitacora.Id_productoBodega = ProductoBodega.Id " +
                        "INNER JOIN Bodega ON ProductoBodega.Id_bodega = Bodega.Id " +
                        "INNER JOIN Productos ON ProductoBodega.Id_producto = Productos.Id";


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
