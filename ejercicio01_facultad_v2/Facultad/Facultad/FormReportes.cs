using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facultad.Persistencia;
using Facultad.Entidades;

namespace Facultad
{
    public partial class FormReportes : Form
    {
        private readonly PersistenciaUtils pu = new PersistenciaUtils();

        public FormReportes()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            String Mensaje = "";
            Boolean a =int.TryParse(textAlumno.Text.ToString(), out int codigo);

            if (!a)
            {
                Mensaje = "El código de alumno debe ser numérico";
            }
            else
            {
                Alumno alu = datosAlumno(codigo);
                if(alu == null)
                {
                    Mensaje = "No existe el alumno con el código ingresado";
                }
                else
                {
                    Mensaje="Total de exámenes: "+alu.Examenes.Count().ToString();
                }
            }
            MessageBox.Show(Mensaje);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            String Mensaje = "";
            Boolean a = int.TryParse(textAlumno.Text.ToString(), out int codigo);

            if (!a)
            {
                Mensaje="El código de alumno debe ser numérico";
            }
            else
            {
                Alumno alu = datosAlumno(codigo);
                if (alu == null)
                {
                    Mensaje = "No existe el alumno con el código ingresado";
                }
                else
                {
                    List<ReporteAlu1> r = alu.Reporte1();
                    foreach (ReporteAlu1 r1 in r)
                    {
                        Mensaje += "Carrera: " + r1.Carrera+ "\n";
                        Mensaje += "Materias aprobadas: " + r1.CantMatAprobadas.ToString() + "\n";
                        Mensaje += "Materias faltantes: " + r1.CantMatPendientes.ToString() + "\n";
                        Mensaje += "Porcentaje restante: " + r1.PorcentajePendiente.ToString() + "%\n\n";
                    }
                }
            }
            MessageBox.Show(Mensaje);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            String Mensaje = "";
            Alumno aluElegido=null;
            List<Alumno> lstAlumnos = ListaAlumnos();
            foreach (Alumno alu in lstAlumnos)
            {
                if(aluElegido == null)
                {
                    aluElegido = alu;
                }
                else
                {
                    //Si el alumno del bucle tiene más de una carrera y más materias aprobadas que el elegido lo reemplaza
                    //en el Reporte1 la lista cointiene solo las carreras con materias aprobadas (asumiendo que esas son las carreras que está cursando)
                    if (alu.Carreras.Count() > 1&& alu.MateriasAprobadas() > aluElegido.MateriasAprobadas())
                    {
                        aluElegido = alu;
                    }
                }

            }
            //Agrego en el mensaje el nombre y apellido del alumno elegido
            Mensaje = aluElegido.Nombre + " " + aluElegido.Apellido + "\n";

            //Agrego en el mensaje las carreras con materias aproabdas
            foreach(ReporteAlu1 r in aluElegido.Reporte1())
            {
                Mensaje += r.Carrera + "\n";
            }
            //Agrego el total de materias aprobadas
            Mensaje += aluElegido.MateriasAprobadas().ToString() + "\n";

            MessageBox.Show(Mensaje);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            String Mensaje = "";
            Boolean a = int.TryParse(textAlumno.Text.ToString(), out int codigo);

            if (!a)
            {
                Mensaje = "El código de alumno debe ser numérico";
            }
            else
            {
                Alumno alu = datosAlumno(codigo);
                if (alu == null)
                {
                    Mensaje = "No existe el alumno con el código ingresado";
                }
                else
                {
                    List<String> r = alu.MateriasDesregularizadas();
                    foreach (String r1 in r)
                    {
                        Mensaje += r1 + "\n";
                    }
                }
            }
            MessageBox.Show(Mensaje);
        }

        private List<Alumno> ListaAlumnos()
        {
            List<Alumno> lstAlumnos = new List<Alumno>();

            List<String> listado = pu.ListarArchivo("alumnos.csv");

            foreach (String registro in listado)
            {
                String[] aluRg = registro.Split(';');
                List<Carrera> listaCarreras = CarrerasDelAlumno(aluRg[4]);
                List<Examen> listaExamenes = ExamenesDelAlumno(int.Parse(aluRg[0]));
                Alumno alumno = new Alumno(aluRg, listaCarreras, listaExamenes);
                lstAlumnos.Add(alumno);
            }
            return lstAlumnos;
        }

        private Alumno datosAlumno(int codigo)
        {
            Alumno salida = null;

            String[] datos_alumno = pu.EncontrarRegPorColVal("alumnos.csv", 0, codigo.ToString());

            //Validar que el alumno exista
            if (datos_alumno.Length != 0)
            {
                List<Carrera> listaCarreras = CarrerasDelAlumno(datos_alumno[4]);
                List<Examen> listaExamenes = ExamenesDelAlumno(codigo);

                salida = new Alumno(datos_alumno, listaCarreras, listaExamenes);
            }
            return salida;
        }

        private List<Examen> ExamenesDelAlumno(int codigoAlu)
        {
            List<Examen> salida = new List<Examen>();
            List<String> fileExamenes = pu.ListarArchivo("examenes.csv");
            foreach (String registro in fileExamenes)
            {
                String[] csvExamen = registro.Split(';');
                Examen examen = new Examen(csvExamen);
                //Validar que el examen corresponda al idAlumo
                if (examen.IdAlumno == codigoAlu)
                {
                    salida.Add(examen);
                }
            }
            return salida;
        }

        private List<Carrera> CarrerasDelAlumno(String carrerasAlu)
            {
            String[] CarrerasAlu = carrerasAlu.Split(',');

            List<Carrera> salida = new List<Carrera>();
            List<String> fileCarreras = pu.ListarArchivo("carreras.csv");
            foreach (String regCarrera in fileCarreras)
            {
                String[] csvCarrera = regCarrera.Split(';');

                //Cargar lista de materias
                List<Materia> listaMaterias = new List<Materia>();
                List<String> filetMaterias = pu.ListarArchivo("materias.csv");
                foreach (String regMateria in filetMaterias)
                {
                    String[] csvMateria = regMateria.Split(';');
                    Materia materia = new Materia(csvMateria);
                    //Validar que la materia corresponda al idCarrera
                    // en la posición 7 del csvMateria hay una lista de idCarrera separadas por coma
                    String[] CarrerasDeMateria = csvMateria[6].Split(',');
                    int n = CarrerasDeMateria.Count();
                    for (int i = 0; i < n; i++)
                    {
                        //Validar que la materia corresponda al idCarrera
                        if (csvCarrera[0] == CarrerasDeMateria[i].Trim())
                        {
                            listaMaterias.Add(materia);
                            break;
                        }
                    }
                }

                Carrera carrera = new Carrera(csvCarrera, listaMaterias);

                //Validar que la carrera corresponda al idAlumo
                for (int i = 0; i < CarrerasAlu.Length; i++)
                {
                    if (CarrerasAlu[i].Trim() == csvCarrera[0])
                    {
                        salida.Add(carrera);
                        break;
                    }
                }
            }
            return salida;
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu formMenu = new FormMenu();
            formMenu.ShowDialog();
            this.Close();
        }

    }
}
