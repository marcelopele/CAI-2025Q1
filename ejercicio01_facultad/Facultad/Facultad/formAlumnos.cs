using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facultad.Entidades;
using Facultad.Persistencia;

namespace Facultad
{
    public partial class formAlumnos : Form
    {
        private readonly PersistenciaUtils pu = new PersistenciaUtils();

        public formAlumnos()
        {
            InitializeComponent();

            //Cargar los datos de los alumnos al abrir el form
            List<String> listado = pu.ListarArchivo("alumnos.csv");

            foreach (String registro in listado)
            {
                //Alumno alumno = new Alumno(registro);
                //lstAlumnos.Items.Add(alumno.ToString());
                //a un listview también se le podría directamente agregar el objeto alumno y va a mostrar el ToString pero conteniendo todos los datos del objeto
                //lstAlumnos.Items.Add(alumno);

                String[] datos = registro.Split(';');
                grdAlumnos.Rows.Add(datos[1], datos[2], datos[0], datos[3]);

            }

        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu fm = new Menu();
            fm.ShowDialog();

        }

        private void grdAlumnos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = grdAlumnos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtApellido.Text = grdAlumnos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCodigo.Text = grdAlumnos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtFechaNac.Text = grdAlumnos.Rows[e.RowIndex].Cells[3].Value.ToString();


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
