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

namespace Facultad
{
    public partial class Login : Form
    {
        PersistenciaUtils pu = new PersistenciaUtils();


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
                    // Marcar error en el campo de usuario
                    errUsr.Visible = true;
                }

                if (string.IsNullOrEmpty(clave))
                {
                    // Marcar error en el campo de clave
                    errPwd.Visible = true;
                }
                // Mostrar mensaje de error
                errMsj.Text = "* Completar datos obligatorios";
                errMsj.Visible = true;
            }

            //2. Si los datos se completaron validarlos con el archivo
            else
            {
                String[] datos_usuario = pu.EncontrarRegPorColVal("credenciales.csv", 0, usuario);

                //2.1. Validar que el usuario exista
                //     Si no existe, marcar error en el campo de usuario
                if (datos_usuario.Length == 0)
                {
                    errUsr.Visible = true;                                          // Marcar error en el campo de usuario
                    errMsj.Text = "* Usuario no encontrado";                        // Mostrar mensaje de error
                    errMsj.Visible = true;
                }

                //2.2. Si el usuario existe, validar que no esté bloqueado (intentos excedidos >=3)
                else if (Convert.ToInt32(datos_usuario[5]) >= 3)
                {
                    errUsr.Visible = true;                                          // Marcar error en el campo de usuario
                    errMsj.Text = "* Usuario bloqueado";                            // Mostrar mensaje de error
                    errMsj.Visible = true;
                }

                //2.3. Si el usuario existe y no está bloqueado, validar que la clave sea correcta
                else if (datos_usuario[1] != clave)
                {
                    errPwd.Visible = true;                                          // Marcar error en el campo de clave
                    errMsj.Text = "* Clave incorrecta";                             // Mostrar mensaje de error
                    errMsj.Visible = true;

                    // Se incrementa el contador de intentos erroneos
                    int intentos = Convert.ToInt32(datos_usuario[5]) + 1;
                    datos_usuario[5] = intentos.ToString();
                    pu.ModificarRegistroCompleto("credenciales.csv", 0, usuario, datos_usuario);
                }

                //2.4. Si la clave es correcta, llevar el contador de intentos a 0
                //                              y validar fecha de caducidad
                else
                {
                    // Se lleva el contador de intentos a 0
                    datos_usuario[5] = "0";
                    pu.ModificarRegistroCompleto("credenciales.csv", 0, usuario, datos_usuario);

                    // 2.4.1. Si la fecha de caducidad es menor a la actual, solicitar cambio de clave
                    if (Convert.ToDateTime(datos_usuario[4]) < DateTime.Now)
                    {
                        errPwd.Visible = true;                                      // Marcar error en el campo de clave
                        errMsj.Text = "* Su clave ha caducado debe cambiarla";      // Mostrar mensaje de error
                        errMsj.Visible = true;
                    }

                    // 2.4.2. Si todo es correcto, abrir el menú principal
                    else
                    {
                        this.Hide();
                        Menu f2 = new Menu();
                        f2.ShowDialog();
                    }

                }
            }
        }


        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {

            this.Hide();
            CrearUsr f3 = new CrearUsr();
            f3.ShowDialog();

        }

        private void btnCambiarClave_Click(object sender, EventArgs e)
        {

        }
    }
}
