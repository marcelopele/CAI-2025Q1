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
        Alumno alu;
        public formAlumnos()
        {
            InitializeComponent();
            recargarDataGridView();
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu fm = new Menu();
            fm.ShowDialog();
        }

        private void grdAlumnos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            String n    = grdAlumnos.Rows[e.RowIndex].Cells[0].Value.ToString();
            String a    = grdAlumnos.Rows[e.RowIndex].Cells[1].Value.ToString();
            int c       = int.Parse(grdAlumnos.Rows[e.RowIndex].Cells[2].Value.ToString());
            DateTime f  = DateTime.Parse(grdAlumnos.Rows[e.RowIndex].Cells[3].Value.ToString());
            
            Alumno alu  = new Alumno(n, a, f, c);

            txtNombre.Text = alu.Nombre;
            txtApellido.Text = alu.Apellido;
            txtCodigo.Text = alu.Codigo.ToString();
            txtFechaNac.Text = alu.FechaNac.ToString();

            txtFechaNacReadOnly.Text = alu.FechaNac.ToString("D");

            formatosC();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //LimpiarCampos
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCodigo.Text = "";
            txtFechaNac.Text = "";


            //Dejar visibles y editables los campos y botones correctos
            txtNombre.ReadOnly = false;
            txtApellido.ReadOnly = false;
            txtCodigo.ReadOnly = false;
            txtFechaNac.Visible = true;
            txtFechaNacReadOnly.Visible = false;

            grdAlumnos.Enabled = false;

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

            grdAlumnos.Enabled = false;

            btnModificar.Visible = false;
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
            grdAlumnos.Enabled = false;

            btnModificar.Visible = false;
            btnEliminar.Visible = false;
            btnConfirmar.Visible = true;
            btnCancelar.Visible = true;
            btnCredencial.Enabled = false;
            btnNombreCompleto.Enabled = false;
            btnSaludo.Enabled = false;

            //Modo Alta
            txtModo.Text = "B";

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            formatosC();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //Select case según el txtModo.Text
            switch (txtModo.Text)
            {
                case "A":
                    //Alta
                    alu = new Alumno(txtNombre.Text, txtApellido.Text, DateTime.Parse(txtFechaNac.Text), int.Parse(txtCodigo.Text));

                    pu.AgregarRegistro("alumnos.csv", alu.ToStringCSV());

                    formatosC();
                    recargarDataGridView();
                    break;
                case "M":
                    //Modificar
                    alu = new Alumno(txtNombre.Text, txtApellido.Text, DateTime.Parse(txtFechaNac.Text), int.Parse(txtCodigo.Text));

                    pu.ModificarRegistroCompleto("alumnos.csv",0, txtCodigo.Text, alu.ToStringCSV());

                    formatosC();
                    recargarDataGridView();
                    break;
                case "B":
                    //Eliminar
                    pu.BorrarRegistro("alumnos.csv", 0, txtCodigo.Text);

                    formatosC();
                    recargarDataGridView();
                    break;
            }

        }

        private void recargarDataGridView()
        {
            //Recargar el DataGridView
            grdAlumnos.Rows.Clear();
            List<String> listado = pu.ListarArchivo("alumnos.csv");
            foreach (String registro in listado)
            {
                String[] datos = registro.Split(';');
                grdAlumnos.Rows.Add(datos[1], datos[2], datos[0], datos[3]);
            }

        }

        private void formatosC()
        {
            grdAlumnos.Enabled = true;

            //Dejar visibles y editables los campos y botones correctos
            txtNombre.ReadOnly = true;
            txtApellido.ReadOnly = true;
            txtCodigo.ReadOnly = true;
            txtFechaNac.Visible = false;
            txtFechaNacReadOnly.Visible = true;

            btnModificar.Visible = true;
            btnEliminar.Visible = true;
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
    }
}
