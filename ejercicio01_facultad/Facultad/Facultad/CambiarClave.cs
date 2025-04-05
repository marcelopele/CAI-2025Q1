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
    public partial class CambiarClave : Form
    {
        public CambiarClave()
        {
            InitializeComponent();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f1 = new Login();
            f1.ShowDialog();
        }
    }
}
