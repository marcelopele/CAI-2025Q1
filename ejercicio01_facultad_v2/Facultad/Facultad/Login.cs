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
    public partial class Login : Form
    {
        private readonly PersistenciaUtils pu = new PersistenciaUtils();

        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string clave = txtClave.Text;

            errUsr.Visible = false;
            errPwd.Visible = false;
            errMsj.Visible = false;

            //1. Validación de datos obligatorios:
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(clave))
            {
                if (string.IsNullOrEmpty(usuario))
                {
                    errUsr.Visible = true;                                          // Marcar error en el campo de usuario
                }
                if (string.IsNullOrEmpty(clave))
                {
                    errPwd.Visible = true;                                          // Marcar error en el campo de clave
                }
                errMsj.Text = "* Completar datos obligatorios";                     // Mostrar mensaje de error
                errMsj.Visible = true;

            }
            //2. Si están los datos obligatorios hacer la validación con datos del archivo
            else
            {
                //2.1. Validar que el usuario exista
                Credenciales credenciales = datosUsuario(usuario);
                if (credenciales==null)
                {
                    errMsj.Text = "* Usuario o clave incorrectos";              // Mostrar mensaje de error
                    errMsj.Visible = true;
                }
                //2.2. Controlar que no sea un usuario bloqueado
                else if (credenciales.usrBloqueado())
                {
                    errMsj.Text = "* Usuario bloqueado";                        // Mostrar mensaje de error
                    errMsj.Visible = true;
                }
                //2.3. Si existe y no está bloqueado controlar la clave
                else if (credenciales.Clave!=clave)
                {
                    errMsj.Text = "* Usuario o clave incorrectos";              // Mostrar mensaje de error
                    errMsj.Visible = true;
                    incrementarIntentos(usuario);
                }

                //2.4. Validar que no haya caducado
                else if (credenciales.claveCaducada())
                {
                    errMsj.Text = "* La clave ha expirado";                     // Mostrar mensaje de error
                    errMsj.Visible = true;

                    this.Hide();
                    CambiarClave formCC = new CambiarClave();
                    formCC.ShowDialog();
                    this.Close();

                }
                //2.6. Si todo está correcto, abrir el formulario principal
                else
                {
                    this.Hide();
                    FormMenu formMenu = new FormMenu();
                    formMenu.ShowDialog();
                    this.Close();
                }
            }
        }

        private void btnCambiarClave_Click(object sender, EventArgs e)
        {
            this.Hide();
            CambiarClave formCC = new CambiarClave();
            formCC.ShowDialog();
            this.Close();
        }
        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearUsr formCU = new CrearUsr();
            formCU.ShowDialog();
            this.Close();
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

        private void incrementarIntentos(String usuario)
        {
            String[] datos_usuario = pu.EncontrarRegPorColVal("credenciales.csv", 0, usuario);
            Credenciales credenciales = new Credenciales(datos_usuario);
            //Si el usuario existe incremento 1 al contador de intentos
            if (!String.IsNullOrEmpty(credenciales.Usuario))
            {
                credenciales.Intentos++;
                String[] nuevos_datos = credenciales.ToStringCSV();
                pu.ModificarRegistroCompleto("credenciales.csv", 0, usuario, nuevos_datos);
            }
        }

    }
}
