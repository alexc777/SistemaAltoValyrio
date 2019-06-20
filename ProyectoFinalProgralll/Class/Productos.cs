using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgralll.Class
{
    public class Productos
    {
        //public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Marca { get; set; }
        public int Categoria { get; set; }
        public int Refrigerado { get; set; }
        public DateTime Fecha_vence { get; set; }
        public int TipoEmpaque { get; set; }
        public DateTime Fecha_creo { get; set; }
        public int Id_bodega { get; set; }
    }
}
