using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Entidades
{
    class Reporte2
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Carrera { get; set; }
        public int CantidadMaterias { get; set; }
        public double Promedio { get; set; }
        public Reporte2(string nombre, string apellido, string carrera, int cantidadMaterias, double promedio)
        {
            Nombre = nombre;
            Apellido = apellido;
            Carrera = carrera;
            CantidadMaterias = cantidadMaterias;
            Promedio = promedio;
        }
    }
}
