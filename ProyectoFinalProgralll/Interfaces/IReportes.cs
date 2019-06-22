using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgralll.Interfaces
{
    public interface IReportes
    {
        DataSet ObtenerProductos();
        DataSet ObtenerProductos(int Id_bodega);
        DataSet ObtenerProductosCategorias(int Id_cagegoria);
        DataSet ObtenerProductosMarca(int Id_Marca);

        DataSet ObtenerProductos(int Id_marca, int Id_Categoria, int Id_bodega);
    }
}
