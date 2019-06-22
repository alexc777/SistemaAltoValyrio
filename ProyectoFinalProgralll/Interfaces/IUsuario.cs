using ProyectoFinalProgralll.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgralll.Interfaces
{
    public interface IUsuario
    {
        void CrearUsuario(Usuarios usuario);
        DataSet BuscarUsuario(string correo);
        DataSet BuscarUsuarioNombre(string nombre);
        DataSet ObtenerUsuarios();
        void EditarUsuario(Usuarios usuario, int id);
        void EliminarUsuario(int id);
        void EliminarUsuario(int id, int estado);
    }
}
