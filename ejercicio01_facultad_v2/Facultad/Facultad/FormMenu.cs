using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facultad
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login formLogin = new Login();
            formLogin.ShowDialog();
            this.Close();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAlumnos formAlumnos = new FormAlumnos();
            formAlumnos.ShowDialog();
            this.Close();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormReportes formReportes = new FormReportes();
            formReportes.ShowDialog();
            this.Close();
        }
    }
}
