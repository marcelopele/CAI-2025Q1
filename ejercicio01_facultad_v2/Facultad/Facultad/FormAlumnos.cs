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
    public partial class FormAlumnos : Form
    {
        private readonly PersistenciaUtils pu = new PersistenciaUtils();

        public FormAlumnos()
        {
            InitializeComponent();
            CargarLista();
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu formMenu = new FormMenu();
            formMenu.ShowDialog();
            this.Close();
        }

        private void CargarLista()
        {
            lstAlumnos.Items.Clear();
            List<String> listado = pu.ListarArchivo("alumnos.csv");

            foreach (String registro in listado)
            {
                String[] aluRg = registro.Split(';');
                List<Carrera> listaCarreras = CarrerasDelAlumno();
                List<Examen> listaExamenes = ExamenesDelAlumno(int.Parse(aluRg[0]));
                Alumno alumno = new Alumno(aluRg, listaCarreras, listaExamenes);
                lstAlumnos.Items.Add(alumno);
            }
        }

        private void lstAlumnos_Click(object sender, EventArgs e)
        {
            var itemSeleccionado = lstAlumnos.SelectedItems;

            if (itemSeleccionado.Count != 0)
            {
                Alumno alumno = (Alumno)itemSeleccionado[0];
                cargarDatosAlu(alumno);
                formatosC();
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //LimpiarCampos
            limpiarDatos();

            //Dejar visibles y editables los campos y botones correctos
            txtNombre.ReadOnly = false;
            txtApellido.ReadOnly = false;
            txtCodigo.ReadOnly = false;
            txtFechaNac.Visible = true;
            txtFechaNacReadOnly.Visible = false;

            lstAlumnos.Enabled = false;

            btnNuevo.Visible = true;
            btnNuevo.Enabled = false;
            btnModificar.Visible = false;
            btnEliminar.Visible = false;
            btnConfirmar.Visible = true;
            btnCancelar.Visible = true;
            btnCredencial.Enabled = false;
            btnNombreCompleto.Enabled = false;
            btnSaludo.Enabled = false;

            //Llevar el foco al primer campo
            txtNombre.Focus();

            //Modo Alta
            txtModo.Text = "A";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Dejar visibles y editables los campos y botones correctos
            txtNombre.ReadOnly = false;
            txtApellido.ReadOnly = false;
            txtCodigo.ReadOnly = true;
            txtFechaNac.Visible = true;
            txtFechaNacReadOnly.Visible = false;

            lstAlumnos.Enabled = false;

            btnNuevo.Visible = false;
            btnModificar.Visible = true;
            btnModificar.Enabled = false;
            btnEliminar.Visible = false;
            btnConfirmar.Visible = true;
            btnCancelar.Visible = true;
            btnCredencial.Enabled = false;
            btnNombreCompleto.Enabled = false;
            btnSaludo.Enabled = false;

            //Llevar el foco al primer campo
            txtNombre.Focus();

            //Modo Modificación
            txtModo.Text = "M";

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Dejar visibles y editables los campos y botones correctos
            lstAlumnos.Enabled = false;

            btnNuevo.Visible = false;
            btnModificar.Visible = false;
            btnEliminar.Visible = true;
            btnEliminar.Enabled = false;
            btnConfirmar.Visible = true;
            btnCancelar.Visible = true;
            btnCredencial.Enabled = false;
            btnNombreCompleto.Enabled = false;
            btnSaludo.Enabled = false;

            //Modo Baja
            txtModo.Text = "B";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var itemSeleccionado = lstAlumnos.SelectedItems;
            if(itemSeleccionado.Count == 0)
            {
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtFechaNac.Text = "";
                txtFechaNacReadOnly.Text = "";
                txtCodigo.Text = "";
            }
            else
            {
                Alumno alumno = (Alumno)itemSeleccionado[0];

                txtNombre.Text = alumno.Nombre;
                txtApellido.Text = alumno.Apellido;
                txtFechaNac.Value = alumno.FechaNac;
                txtFechaNacReadOnly.Text = alumno.FechaNac.ToString("D");
                txtCodigo.Text = alumno.Codigo.ToString();
            }
            formatosC();
        }

        private void formatosC()
        {
            lstAlumnos.Enabled = true;

            //Dejar visibles y editables los campos y botones correctos
            txtNombre.ReadOnly = true;
            txtApellido.ReadOnly = true;
            txtCodigo.ReadOnly = true;
            txtFechaNac.Visible = false;
            txtFechaNacReadOnly.Visible = true;

            btnNuevo.Visible = true;
            btnNuevo.Enabled = true;
            btnModificar.Visible = true;
            btnModificar.Enabled = true;
            btnEliminar.Visible = true;
            btnEliminar.Enabled = true;
            btnConfirmar.Visible = false;
            btnCancelar.Visible = false;
            btnCredencial.Enabled = true;
            btnNombreCompleto.Enabled = true;
            btnSaludo.Enabled = true;

            //Llevar el foco al primer campo
            txtNombre.Focus();

            //Modo Consulta
            txtModo.Text = "C";

        }

        private void limpiarDatos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtFechaNac.Text = "";
            txtFechaNacReadOnly.Text = "";
            txtCodigo.Text = "";
        }

        private Boolean controlEdad(DateTime nacimiento)
        {
            Boolean salida = true;
            if(DateTime.Now.Year - nacimiento.Year>100||
               DateTime.Now.Year - nacimiento.Year< 18)
            {
                salida = false;
            }
            return salida;
        }

        private Boolean controlCodigo(int Codigo)
        {
            Boolean salida = true;
            if (Codigo < 10000 || Codigo > 99999) {
                salida = false;
            }
            return salida;
        }

        private Alumno datosAlumno(int codigo)
        {
            Alumno salida = null;

            String[] datos_alumno = pu.EncontrarRegPorColVal("alumnos.csv", 0, codigo.ToString());

            //Validar que el alumno exista
            if (datos_alumno.Length != 0)
            {
                List<Carrera> listaCarreras = CarrerasDelAlumno();
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

        private List<Carrera> CarrerasDelAlumno()
        {   //se asume que todos los alumnos tienen todas las carreras

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
                        if (csvCarrera[0] == CarrerasDeMateria[i])
                        {
                            listaMaterias.Add(materia);
                        }
                    }
                }

                Carrera carrera = new Carrera(csvCarrera, listaMaterias);

                //Validar que la carrera corresponda al idAlumo
                salida.Add(carrera);
            }
            return salida;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            List<Carrera> listaCarreras= new List<Carrera>();
            List<Examen> listaExamenes = new List<Examen>();

            {
                errMsj.Visible = false;

                //Select case según el txtModo.Text
                switch (txtModo.Text)
                {
                    case "A":
                        //Alta
                        //  A.1. Controlar datos recibidos
                        //  A.1.1. Controlar datos obligatorios
                        if (string.IsNullOrEmpty(txtNombre.Text) ||
                            string.IsNullOrEmpty(txtApellido.Text) ||
                            string.IsNullOrEmpty(txtFechaNac.Text) ||
                            string.IsNullOrEmpty(txtCodigo.Text))
                        {
                            errMsj.Text = "Completar datos obligatorios";
                            errMsj.Visible = true;
                        }
                        //  A.1.2 Validar fecha de nacimiento
                        else if(!controlEdad(txtFechaNac.Value))
                        {
                            errMsj.Text = "Revisar fecha de nacimiento";
                            errMsj.Visible = true;
                        }
                        else if(!controlCodigo(int.Parse(txtCodigo.Text)))
                        {
                            errMsj.Text = "Revisar el Código del alumno";
                            errMsj.Visible = true;
                        }

                        //  A.2. Si se superan los controles sobre los datos recibidos:
                        else
                        {
                            String[] newAluArr = new String[4];
                            newAluArr[0] = txtCodigo.Text;
                            newAluArr[1] = txtNombre.Text;
                            newAluArr[2] = txtApellido.Text;
                            newAluArr[3] = txtFechaNac.Value.ToString("yyyy-MM-dd");

                            listaCarreras = CarrerasDelAlumno();
                            listaExamenes = ExamenesDelAlumno(int.Parse(txtCodigo.Text));

                            Alumno newAlu = new Alumno(newAluArr, listaCarreras, listaExamenes);
                            String[] preAlu = pu.EncontrarRegPorColVal("alumnos.csv", 0, newAlu.Codigo.ToString());

                            //  A.2.1.Validar que el código de alumno no exista previamente
                            if (datosAlumno(newAlu.Codigo)!=null)
                            {
                                errMsj.Text = "Código de alumno ya registrado";
                                errMsj.Visible = true;
                            }
                            else
                            {
                                pu.AgregarRegistro("alumnos.csv", newAlu.ToStringCSV());

                                formatosC();
                                CargarLista();
                                txtFechaNacReadOnly.Text = txtFechaNac.Value.ToString("D");
                            }
                        }

                        break;

                    case "M":
                        //Modificar
                        String[] updAluArr = new String[4];
                        updAluArr[0] = txtCodigo.Text;
                        updAluArr[1] = txtNombre.Text;
                        updAluArr[2] = txtApellido.Text;
                        updAluArr[3] = txtFechaNac.Value.ToString("yyyy-MM-dd");

                        listaCarreras = CarrerasDelAlumno();
                        listaExamenes = ExamenesDelAlumno(int.Parse(txtCodigo.Text));

                        Alumno updAlu = new Alumno(updAluArr, listaCarreras, listaExamenes);
                        pu.ModificarRegistroCompleto("alumnos.csv", 0, updAlu.Codigo.ToString(), updAlu.ToStringCSV());

                        formatosC();
                        CargarLista();
                        txtFechaNacReadOnly.Text= txtFechaNac.Value.ToString("D");
                        break;

                    case "B":
                        //Eliminar
                        var itemSeleccionado = lstAlumnos.SelectedItems;
                        Alumno delAlu = (Alumno)itemSeleccionado[0];
                        pu.BorrarRegistro("alumnos.csv", 0, delAlu.Codigo.ToString());

                        formatosC();
                        CargarLista();
                        limpiarDatos();

                        break;
                }

            }
        }

        private void cargarDatosAlu(Alumno alu)
        {
            txtNombre.Text = alu.Nombre;
            txtApellido.Text = alu.Apellido;
            txtFechaNac.Value = alu.FechaNac;
            txtFechaNacReadOnly.Text = alu.FechaNac.ToString("D");
            txtCodigo.Text = alu.Codigo.ToString();

            //Actualizar grilla de carreras:
            List<ReporteAlu1> datosGrd = alu.Reporte1();
            grdReporteAlu.Rows.Clear();
            foreach (ReporteAlu1 item in datosGrd)
            {
                grdReporteAlu.Rows.Add(item.Carrera, item.CantMatAprobadas, item.CantMatPendientes, item.PorcentajePendiente);
            }
        }

        private void btnCredencial_Click(object sender, EventArgs e)
        {
            var itemSeleccionado = lstAlumnos.SelectedItems;

            if (itemSeleccionado.Count != 0)
            {
                Alumno alumno = (Alumno)itemSeleccionado[0];
                alumno.GetCredencial();
            }
        }

        private void btnNombreCompleto_Click(object sender, EventArgs e)
        {
            var itemSeleccionado = lstAlumnos.SelectedItems;

            if (itemSeleccionado.Count != 0)
            {
                Alumno alumno = (Alumno)itemSeleccionado[0];
                alumno.GetNombreCompleto();
            }
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            var itemSeleccionado = lstAlumnos.SelectedItems;

            if (itemSeleccionado.Count != 0)
            {
                Alumno alumno = (Alumno)itemSeleccionado[0];
                alumno.GetSaludoInformal();
            }

        }
    }
}
