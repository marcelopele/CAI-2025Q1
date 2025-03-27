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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f1 = new Login();
            f1.ShowDialog();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            this.Hide();
            formAlumnos fa = new formAlumnos();
            fa.ShowDialog();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            this.Hide();
            formEmpleados fe = new formEmpleados();
            fe.ShowDialog();
        }
    }
}
