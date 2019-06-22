using ProyectoFinalProgralll.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgralll.Interfaces
{
    public interface IMarcaCategoria
    {
        void CrearMarca(Marca marca);
        DataSet BuscarMarca(string nombre);
        DataSet BuscarMarca(string nombre, int estado);
        void EditarMarca(Marca marca, int id);
        void EliminarMarca(int id);
        void EliminarMarca(int id, int estado);
        DataSet ObtenerMarcas();

        void CrearCategoria(Categoria categoria);
        DataSet ObtenerCategorias();
        DataSet BuscarCategoria(string nombre);
        DataSet BuscarCategoria(string nombre, int estado);
        void EditarCategoria(Categoria categoria,int id);
        void EliminarCategoria(int id);
        void EliminarCategoria(int id, int estado);
    }
}
