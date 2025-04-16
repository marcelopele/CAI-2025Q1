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
        private readonly PersistenciaUtils pu = new PersistenciaUtils();

        public CrearUsr()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login formLogin = new Login();
            formLogin.ShowDialog();
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            errNombre.Visible = false;
            errApellido.Visible = false;
            errMail.Visible = false;
            errUsr.Visible = false;
            errPwd.Visible = false;
            errMsj.Visible = false;

            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            String mail = txtMail.Text;
            String usuario = txtUsuario.Text;
            String clave = txtClave.Text;

            String errMsj1 = "";
            String errMsjAd = "";

            // 1. Validaciones de datos obligatorios y contenido:
            if (string.IsNullOrEmpty(nombre) ||
                string.IsNullOrEmpty(apellido) ||
                string.IsNullOrEmpty(mail) ||
                string.IsNullOrEmpty(usuario) ||
                string.IsNullOrEmpty(clave) ||
                usuario.Length < 6 ||
                clave.Length < 6)
            {
                if (string.IsNullOrEmpty(nombre))
                {
                    errNombre.Visible = true;                                       // Marcar error en el campo de nombre
                    errMsj1 = "* Completar datos obligatorios\r\n";
                }
                if (string.IsNullOrEmpty(apellido))
                {
                    errApellido.Visible = true;                                     // Marcar error en el campo de apellido
                    errMsj1 = "* Completar datos obligatorios\r\n";
                }
                if (string.IsNullOrEmpty(mail))
                {
                    errMail.Visible = true;                                         // Marcar error en el campo de mail
                    errMsj1 = "* Completar datos obligatorios\r\n";
                }
                if (string.IsNullOrEmpty(usuario))
                {
                    errUsr.Visible = true;                                          // Marcar error en el campo de usuario
                    errMsj1 = "* Completar datos obligatorios\r\n";
                }
                else if (usuario.Length < 6)
                {
                    errUsr.Visible = true;                                          // Marcar error en el campo de usuario
                    errMsjAd += "* El usuario debe contener 6 o más caracteres\r\n";
                }
                if (string.IsNullOrEmpty(clave))
                {
                    errPwd.Visible = true;                                          // Marcar error en el campo de clave
                    errMsj1 = "* Completar datos obligatorios\r\n";
                }
                else if (clave.Length < 6)
                {
                    errPwd.Visible = true;                                          // Marcar error en el campo de clave
                    errMsjAd += "* La clave debe contener 6 o más caracteres\r\n";
                }

                errMsj.Text = errMsj1 + errMsjAd;                                   // Mostrar mensaje de error
                errMsj.Visible = true;
            }
            //2. Si los datos ingresados superan las validaciones
            //   controlar que no exista el usuario previamente
            else
            {
                Credenciales credenciales = datosUsuario(usuario);
                //2.1. Si el usuario ya existe da error
                if (credenciales != null)
                {
                    {
                        errMsj.Text = "* El usuario ya existe";                     // Mostrar mensaje de error
                        errMsj.Visible = true;
                    }
                }
                //2.2. Si todo es correcto, crea el usuario y vuele al login
                else
                {
                    String[] nuevoUsuario = new string[11];
                    nuevoUsuario[0] = usuario;
                    nuevoUsuario[1] = clave;
                    nuevoUsuario[2] = DateTime.Now.ToString("yyyy-MM-dd");              // Fecha de creación
                    nuevoUsuario[3] = DateTime.Now.ToString("yyyy-MM-dd");              // Fecha de modificación
                    nuevoUsuario[4] = "0";                                              // Intentos
                    nuevoUsuario[5] = "";                                               // clave-1
                    nuevoUsuario[6] = "";                                               // clave-2
                    nuevoUsuario[7] = "";                                               // clave-3
                    nuevoUsuario[8] = nombre;
                    nuevoUsuario[9] = apellido;
                    nuevoUsuario[10] = mail;

                    pu.AgregarRegistro("credenciales.csv", nuevoUsuario);

                    this.Hide();
                    Login formLogin = new Login();
                    formLogin.ShowDialog();
                    this.Close();
                }
            }

        }


        private Credenciales datosUsuario(String usuario)
        {
            Credenciales salida = null;

            String[] datos_usuario = pu.EncontrarRegPorColVal("credenciales.csv", 0, usuario);

            //Validar que el usuario exista
            if (datos_usuario.Length != 0)
            {
                Credenciales credenciales = new Credenciales(datos_usuario);
                salida = credenciales;
            }
            return salida;
        }

    }
}
