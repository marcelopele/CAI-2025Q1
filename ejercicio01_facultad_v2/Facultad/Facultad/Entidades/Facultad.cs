using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Entidades
{
    internal class Facultad
    {
        //Atributos
        private List<Alumno> _alumnos;
        private int _cantidadSedes;
        private List<Empleado> _empleados;
        private String _nombre;

        //Propiedades
        public List<Alumno> Alumnos { get => _alumnos; set => _alumnos = value; }
        public int CantidadSedes { get => _cantidadSedes; set => _cantidadSedes = value; }
        public List<Empleado> Empleados {  get => _empleados; set => _empleados = value;}
        public String Nombre { get => _nombre; set => _nombre = value; }


    }
}
