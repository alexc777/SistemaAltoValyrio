using ProyectoFinalProgralll.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgralll.Interfaces
{
    public interface IUsuario
    {
        void CrearUsuario(Usuarios usuario);
        void BuscarUsuario(string correo);
        void EditarUsuario(int id);
        void EliminarUsuario(int id);
        void EliminarUsuario(int id, int estado);
    }
}
