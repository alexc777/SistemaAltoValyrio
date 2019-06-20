using ProyectoFinalProgralll.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgralll.Interfaces
{
    public interface IMarcaCategoria
    {
        void CrearMarca(Marca marca);
        void BuscarMarca(string nombre);
        void BuscarMarca(string nombre, int estado);
        void EditarMarca(int id);
        void EliminarMarca(int id);
        void EliminarMarca(int id, int estado);

        void CrearCategoria(Categoria categoria);
        void BuscarCategoria(string nombre);
        void BuscarCategoria(string nombre, int estado);
        void EditarCategoria(int id);
        void EliminarCategoria(int id);
        void EliminarCategoria(int id, int estado);
    }
}
