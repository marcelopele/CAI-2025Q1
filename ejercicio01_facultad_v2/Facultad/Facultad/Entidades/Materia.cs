using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Entidades
{
    internal class Materia
    {
        //Atributos
        private int _id;
        private String _nombre;

        //Propiedades
        public int Id { get => _id; set => _id = value; }
        public String Nombre { get => _nombre; set => _nombre = value; }

        //Constructor
        public Materia(int id, String nombre)
        {
            this.Id = id;
            this.Nombre = nombre;
        }

        //Constructor con registro del csv
        public Materia(String[] datos)
        {
            this.Id = int.Parse(datos[0]);
            this.Nombre = datos[1];
        }
    }
}
