using ProyectoFinalProgralll.Class;
using System;
using System.Collections.Generic;
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

        //Tabla hubicacion producto
        void GuardarHubiProducto(HubicacionProducto producto);
        void BuscarHubiProducto(string nombre);
        void BuscarHubiProducto(string nombre, int estado);
        void ActualizarHubiProducto(HubicacionProducto producto);
        void ElimiHubinarProducto(int id);
    }
}
