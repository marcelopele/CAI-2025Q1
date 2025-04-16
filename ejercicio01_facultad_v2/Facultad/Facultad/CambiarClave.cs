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
    public partial class CambiarClave : Form
    {
        private readonly PersistenciaUtils pu = new PersistenciaUtils();

        public CambiarClave()
        {
            InitializeComponent();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            errUsr.Visible = false;
            errClaveActual.Visible = false;
            errClaveNva1.Visible = false;
            errClaveNva2.Visible = false;
            errMsj.Visible = false;

            String usuario = txtUsuario.Text;
            String clave_actual = txtClaveActual.Text;
            String clave_nva1 = txtClaveNva1.Text;
            String clave_nva2 = txtClaveNva2.Text;

            String errMsj1 = "";
            String errMsjAd = "";

            // 1. Validaciones de datos obligatorios y contenido:
            if (string.IsNullOrEmpty(usuario) ||
                string.IsNullOrEmpty(clave_actual) ||
                string.IsNullOrEmpty(clave_nva1) ||
                string.IsNullOrEmpty(clave_nva2) ||
                clave_actual.Length < 6 ||
                clave_nva1.Length < 6 ||
                clave_nva2.Length < 6 ||
                clave_nva2 != clave_nva1)
            {
                if (string.IsNullOrEmpty(usuario))
                {
                    errUsr.Visible = true;                                              // Marcar error en el campo de usuario
                    errMsj1 = "* Completar datos obligatorios\r\n";
                }

                if (string.IsNullOrEmpty(clave_actual))
                {
                    errClaveActual.Visible = true;                                      // Marcar error en el campo de clave actual
                    errMsj1 = "* Completar datos obligatorios\r\n";
                }

                if (string.IsNullOrEmpty(clave_nva1))
                {
                    errClaveNva1.Visible = true;                                        // Marcar error en el campo de clave nueva 1
                    errMsj1 = "* Completar datos obligatorios\r\n";
                }
                else if (clave_nva1.Length < 6)
                {
                    errClaveNva1.Visible = true;                                        // Marcar error en el campo de clave nueva 1
                    errMsjAd += "* La clave nueva debe contener 6 o más caracteres\r\n";
                }

                if (string.IsNullOrEmpty(clave_nva2))
                {
                    errClaveNva2.Visible = true;                                        // Marcar error en el campo de clave nueva 2
                    errMsj1 = "* Completar datos obligatorios\r\n";
                }
                else if (clave_nva2 != clave_nva1)
                {
                    errClaveNva2.Visible = true;                                        // Marcar error en el campo de clave nueva 2
                    errMsjAd += "* Las contraseñas no coincide\r\n";
                }

                errMsj.Text = errMsj1 + errMsjAd;                                       // Mostrar mensaje de error
                errMsj.Visible = true;
            }
            //2. Si los datos ingresados superan las validaciones
            //   controlar que exista el usuario ingresado y la clave actual sea correcta
            //   que las nuevas coincida entre si
            //   y no estén entre las últimas 3 ni la actual
            else
            {
                Credenciales credenciales = datosUsuario(usuario);
                //2.1. Validar que el usuario exista
                if (credenciales == null)
                {
                    {
                        errMsj.Text = "* Usuario o clave incorrectos";              // Mostrar mensaje de error
                        errMsj.Visible = true;
                        incrementarIntentos(usuario);
                    }
                }
                //2.2. Controlar que no sea un usuario bloqueado
                else if (credenciales.usrBloqueado())
                {
                    errMsj.Text = "* Usuario bloqueado";                        // Mostrar mensaje de error
                    errMsj.Visible = true;
                }
                //2.3. Si existe y no está bloqueado controlar que sea la clave correcta
                else if (credenciales.Clave != clave_actual)
                {
                    errMsj.Text = "* Usuario o clave incorrectos";              // Mostrar mensaje de error
                    errMsj.Visible = true;
                    incrementarIntentos(usuario);
                }
                // 2.4. Y controlar que la nueva clave no coincida con la actual o las ultimas 3
                else if (!credenciales.validarNuevaClave(clave_nva1))
                {
                    errMsj.Text = "* Usuario o clave incorrectos";              // Mostrar mensaje de error
                    errMsj.Visible = true;
                    incrementarIntentos(usuario);
                }
                // 2.5. Si todo es correcto, mueve claves anteriores y cambia la clave actual,
                //      actualiza fechas de modificación e intentos
                //      y vuelve al login
                else
                {
                    credenciales.Clave_3 = credenciales.Clave_2;
                    credenciales.Clave_2 = credenciales.Clave_1;
                    credenciales.Clave_1 = credenciales.Clave;
                    credenciales.Clave = clave_nva1;
                    credenciales.FhModificacion = DateTime.Now;
                    credenciales.Intentos = 0;

                    String[] datos = credenciales.ToStringCSV();
                    pu.ModificarRegistroCompleto("credenciales.csv", 0, credenciales.Usuario, datos);

                    this.Hide();
                    Login formLogin = new Login();
                    formLogin.ShowDialog();
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login formLogin = new Login();
            formLogin.ShowDialog();
            this.Close();
        }

        private Credenciales datosUsuario(String usuario)
        {
            Credenciales salida = null;

            String[] datos_usuario = pu.EncontrarRegPorColVal("credenciales.csv", 0, usuario);

            //Validar que el usuario exista
            if (datos_usuario.Length == 0)
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
