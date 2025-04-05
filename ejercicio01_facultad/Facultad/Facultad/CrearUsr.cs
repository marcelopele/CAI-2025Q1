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
    public partial class CrearUsr : Form
    {
        PersistenciaUtils pu = new PersistenciaUtils();

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
            errNombre.Visible = false;
            errApellido.Visible = false;
            errMail.Visible = false;
            errUsr.Visible = false;
            errPwd.Visible = false;
            errMsj.Visible = false;

            String nombre=txtNombre.Text;
            String apellido=txtApellido.Text;
            String mail= txtMail.Text;
            String usuario = txtUsuario.Text;
            String clave = txtClave.Text;

            String errMsj2 = "";

            // 1. Validaciones de datos obligatorios y contenido:
            if (string.IsNullOrEmpty(nombre) || 
                string.IsNullOrEmpty(apellido) ||
                string.IsNullOrEmpty(mail) ||
                string.IsNullOrEmpty(usuario) ||
                string.IsNullOrEmpty(clave) ||
                usuario.Length < 8 ||
                clave.Length < 8)
            {
                if (string.IsNullOrEmpty(nombre))
                {
                    errNombre.Visible = true;                                   // Marcar error en el campo de nombre
                }
                if (string.IsNullOrEmpty(apellido))
                {
                    errApellido.Visible = true;                                 // Marcar error en el campo de apellido
                }
                if (string.IsNullOrEmpty(mail))
                {
                    errMail.Visible = true;                                     // Marcar error en el campo de mail
                }
                if (string.IsNullOrEmpty(usuario))
                {
                    errUsr.Visible = true;                                      // Marcar error en el campo de usuario
                }else if (usuario.Length<8)
                {
                    errUsr.Visible = true;                                      // Marcar error en el campo de usuario
                    errMsj2 += "\r\n El usuario debe contener 8 o más caracteres";
                }
                if (string.IsNullOrEmpty(clave))
                {
                    errPwd.Visible = true;                                      // Marcar error en el campo de clave
                }
                else if (clave.Length < 8)
                {
                    errPwd.Visible = true;                                      // Marcar error en el campo de clave
                    errMsj2 += "\r\n La clave debe contener 8 o más caracteres";
                }

                errMsj.Text = "* Completar datos obligatorios"+errMsj2;         // Mostrar mensaje de error
                errMsj.Visible = true;
            }
            //2. Si los datos superan las validaciones controlar que no exista el usuario
            else
            {
                String[] datos_usuario = pu.EncontrarRegPorColVal("credenciales.csv", 0, usuario);
                // 2.1. Si el usuario ya existe da error
                if (datos_usuario.Length > 0)
                {
                    errUsr.Visible = true;                                          // Marcar error en el campo de usuario
                    errMsj.Text = "* Usuario ya existente";                         // Mostrar mensaje de error
                    errMsj.Visible = true;
                }
                // 2.2. Si todo es correcto, crea el usuario
                else
                {
                    String[] nuevoUsuario = new string[12];
                    nuevoUsuario[0] = usuario;
                    nuevoUsuario[1] = clave;
                    nuevoUsuario[2] = DateTime.Now.ToString("yyyy-MM-dd");              // Fecha de creación
                    nuevoUsuario[3] = DateTime.Now.ToString("yyyy-MM-dd");              // Fecha de modificación
                    nuevoUsuario[4] = DateTime.Now.AddDays(30).ToString("yyyy-MM-dd");  // Fecha de caducidad
                    nuevoUsuario[5] = "0"; // Intentos
                    nuevoUsuario[6] = ""; // clave-1
                    nuevoUsuario[7] = ""; // clave-2
                    nuevoUsuario[8] = ""; // clave-3
                    nuevoUsuario[9] = nombre;
                    nuevoUsuario[10] = apellido;
                    nuevoUsuario[11] = mail;

                    pu.AgregarRegistro("credenciales.csv", nuevoUsuario);

                    this.Hide();
                    Login f1 = new Login();
                    f1.ShowDialog();

                }

            }




        }



    }
}
