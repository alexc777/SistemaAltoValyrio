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
        public int Id_marca { get; set; }
        public int Id_categoria { get; set; }
        public int Refrigerado { get; set; }
        public int TipoEmpaque { get; set; }
        public double Cantidad { get; set; }
        public int Estado { get; set; }
        public DateTime Fecha_vence { get; set; }
        public DateTime Fecha_creo { get; set; }
    }
}
