using Facultad.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facultad.Entidades
{
    internal class Alumno : Persona
    {
        //Atributos
        private int _codigo;
        private List<Carrera> _carreras;
        private List<Examen> _examenes;

        //Propiedades
        internal int Codigo { get => _codigo; set => _codigo = value; }
        internal List<Carrera> Carreras { get => _carreras; set => _carreras = value; }
        internal List<Examen> Examenes { get => _examenes; set => _examenes = value; }


        //Constructor con registro del csv
        public Alumno(String[] datos, List<Carrera>listaCarreras, List<Examen>listaExamenes)
        {
            this.Codigo = int.Parse(datos[0]);
            this.Nombre = datos[1];
            this.Apellido = datos[2];
            this.FechaNac = DateTime.Parse(datos[3]);
            this.Carreras = listaCarreras;
            this.Examenes = listaExamenes;
        }

        //Métodos
        public override void GetCredencial()
        {
            if (this.Carreras == null)
            {
                MessageBox.Show("No tiene carreras asignadas");
                return;
            }
            else
            {
                int q = Carreras.Count;
                MessageBox.Show("Credencial de Alumno: " + this.Nombre + " " + this.Apellido + " Materias aprobadas:" + MateriasAprobadas().ToString());
            }
        }

        public override String ToString()
        {
            return " (" + this.Codigo + ")" + this.Apellido + ", " + this.Nombre;
        }

        public String[] ToStringCSV()
        {
            String[] salida = new String[11];

            salida[0] = this.Codigo.ToString();
            salida[1] = this.Nombre;
            salida[2] = this.Apellido;
            salida[3] = this.FechaNac.ToString("yyyy-MM-dd");

            return salida;
        }
 
        public String ToCSV()
        {
            return Codigo+";"+Nombre+";"+Apellido+";"+FechaNac.ToString();
        }

        public String NombreCompleto()
        {
            return this.Nombre + " " + this.Apellido;
        }


        public int MateriasAprobadas()
        {
            int contador = 0;
            foreach (Examen examen in Examenes)
            {
                if (examen.Nota >= 4)
                {
                    contador++;
                }
            }
            return contador;
        }

        public List<int> IdMateriasAprobadas()
        {
            List<int> salida = new List<int>();
            foreach (Examen examen in Examenes)
            {
                if (examen.Nota >= 4)
                {
                    salida.Add(examen.IdMateria);
                }
            }
            return salida;
        }

        public List<ReporteAlu1> Reporte1()
        {
            List<ReporteAlu1> salida = new List<ReporteAlu1>();
            foreach (Carrera carrera in Carreras)
            {
                int cantMatAprobadas = 0;
                int cantMatTotales = carrera.Materias.Count;
                foreach (Materia materia in carrera.Materias)
                {
                    //para cada materia recorro los IdMateriasAprobadas para ver si sumo 1
                    foreach (int idMateria in IdMateriasAprobadas())
                    {
                        if (idMateria == materia.Id)
                        {
                            //si coincide el id de la materia con el id de las materias aprobadas, sumo 1
                            cantMatAprobadas++;
                        }
                    }
                }
                if (cantMatAprobadas > 0)
                {
                    ReporteAlu1 reporte = new ReporteAlu1(carrera.Nombre, cantMatTotales, cantMatAprobadas);
                    salida.Add(reporte);
                }
            }
            return salida;
        }
    }
}
