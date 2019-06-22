using ProyectoFinalProgralll.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgralll.Interfaces
{
    public interface IProducto
    {
        //Tabla productos
        void CrearProducto(Productos producto);
        void BuscarProducto(string nombre);
        void BuscarProducto(string nombre, int estado);
        void EditarProducto(int id);
        void EliminarProducto(int id);

        //Traslados, Tablas: Productos ProductoBodega Vitacora
        DataSet ProductoCategoria(int Id_categoria);
        void TrasladarProducto(ProductoBodega productoBodega);
        void RegistroBitacora(Vitacora bitacora);
        void ActualizarProductoTraslado(int idProducto, int Cantidad);
    }
}
