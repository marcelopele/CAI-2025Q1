using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Entidades
{
    internal class Carrera
    {
        //Atributos
        private int _id;
        private String _nombre;
        private List<Materia> _materias;

        //Propiedades
        public int Id { get => _id; set => _id = value; }
        public String Nombre { get => _nombre; set => _nombre = value; }
        public List<Materia> Materias { get => _materias; set => _materias = value; }

        //Constructor
        public Carrera(int id, String nombre, List<Materia> materias)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Materias = materias;
        }

        //Constructor con registro del csv
        public Carrera(String[] datos, List<Materia> materias)
        {
            this.Id = int.Parse(datos[0]);
            this.Nombre = datos[1];
            this.Materias = materias;
        }
    }
}
