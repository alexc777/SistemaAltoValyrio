using ProyectoFinalProgralll.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgralll.Interfaces
{
    public interface IBodega
    {
        void CrearBodega(Bodega bodega);
        void BuscarBodega(string nombre);
        void BuscarBodega(string nombre,int estado);
        void EditarBodega(int id);
        void EliminarBodega(int id);
        void EliminarBodega(int id, int estado);
    }
}
