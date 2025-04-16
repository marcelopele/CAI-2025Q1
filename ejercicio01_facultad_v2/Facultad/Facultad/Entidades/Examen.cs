using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Entidades
{
    internal class Examen
    {
        //Atributos
        public int _id;
        public int _idMateria;
        public String _tipo;
        public DateTime _fecha;
        public int _nota;
        public int _idAlumno;

        //Propiedades
        public int Id { get => _id; set => _id = value; }
        public int IdMateria { get => _idMateria; set => _idMateria = value; }
        public String Tipo { get => _tipo; set => _tipo = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public int Nota { get => _nota; set => _nota = value; }
        public int IdAlumno { get => _idAlumno; set => _idAlumno = value; }

        //Constructor
        public Examen(int id, int idMateria, String tipo, DateTime fecha, int nota, int idAlumno)
        {
            this.Id = id;
            this.IdMateria = idMateria;
            this.Tipo = tipo;
            this.Fecha = fecha;
            this.Nota = nota;
            this.IdAlumno = idAlumno;
        }

        //Constructor con registro del csv
        public Examen(String[] datos)
        {
            this.Id = int.Parse(datos[0]);
            this.IdMateria = int.Parse(datos[1]);
            this.Tipo = datos[2];
            this.Fecha = DateTime.Parse(datos[3]);
            this.Nota = int.Parse(datos[4]);
            this.IdAlumno = int.Parse(datos[5]);
        }


    }
}
