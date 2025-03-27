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

namespace Facultad
{
    public partial class CrearUsr : Form
    {
        public CrearUsr()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f1 = new Login();
            f1.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string errores = "";

            //Validaciones:

            //Datos obligatorios
            errores += ValidaTxtNull(txtNombre.Text, "No ingresó un Nombre");
            errores += ValidaTxtNull(txtApellido.Text, "No ingresó un Apellido");
            errores += ValidaTxtNull(txtDNI.Text, "No ingresó un DNI");
            errores += ValidaTxtNull(txtUsuario.Text, "No ingresó un Usuario");
            errores += ValidaTxtNull(txtClave.Text, "No ingresó una Clave");

            //DNI numérico entre 1000000 y 99999999
            errores += ValidaIntEntre(txtDNI.Text, "Verificar DNI ingresado", 1000000, 99999999);

            //Validar reglas de negocio para usuario


            //Validar reglas de negocio para clave


            //Controlar que el usuario no exista previamente



            if (errores == "")
            {
                MessageBox.Show("Alta exitosa", "Creación de cuenta");
            }
            else
            {
                MessageBox.Show(errores, "Errores");
            }


        }

        private string ValidaTxtNull(string texto, string msj)
        {
            string salida = "";
            if (string.IsNullOrEmpty(texto))
            {
                salida += msj + "\n";
            }

            return salida;
        }

        private string ValidaIntEntre(string nro_int, string msj, int desde, int hasta)
        {
            int salida_int;
            string salida = "";
            if (!int.TryParse(nro_int, out salida_int))
            {
                salida += msj + "\n";
            }
            else if (salida_int <= desde || salida_int >= hasta)
            {
                salida += msj + "\n";
            }


            return salida;
        }

    }
}
