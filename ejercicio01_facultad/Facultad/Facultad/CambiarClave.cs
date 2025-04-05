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
    public partial class CambiarClave : Form
    {
        private readonly PersistenciaUtils pu = new PersistenciaUtils();

        public CambiarClave()
        {
            InitializeComponent();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f1 = new Login();
            f1.ShowDialog();
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

            String errMsj2 = "";

            // 1. Validaciones de datos obligatorios y contenido:
            if (string.IsNullOrEmpty(usuario) ||
                string.IsNullOrEmpty(clave_actual) ||
                string.IsNullOrEmpty(clave_nva1) ||
                string.IsNullOrEmpty(clave_nva1) ||
                usuario.Length < 8 ||
                clave_actual.Length < 8 ||
                clave_nva1.Length < 8 ||
                clave_nva2.Length < 8)
            {
                if (string.IsNullOrEmpty(usuario))
                {
                    errUsr.Visible = true;                                              // Marcar error en el campo de usuario
                }
                else if (usuario.Length < 8)
                {
                    errUsr.Visible = true;                                              // Marcar error en el campo de usuario
                    errMsj2 += "\r\n El usuario debe contener 8 o más caracteres";
                }

                if (string.IsNullOrEmpty(clave_actual))
                {
                    errClaveActual.Visible = true;                                      // Marcar error en el campo de clave actual
                }
                else if (clave_actual.Length < 8)
                {
                    errClaveActual.Visible = true;                                      // Marcar error en el campo de clave actual
                    errMsj2 += "\r\n La clave actual es incorrecta";
                }

                if (string.IsNullOrEmpty(clave_nva1))
                {
                    errClaveNva1.Visible = true;                                        // Marcar error en el campo de clave nueva 1
                }
                else if (clave_nva1.Length < 8)
                {
                    errClaveNva1.Visible = true;                                        // Marcar error en el campo de clave nueva 1
                    errMsj2 += "\r\n La clave nueva debe contener 8 o más caracteres";
                }

                if (string.IsNullOrEmpty(clave_nva2))
                {
                    errClaveNva2.Visible = true;                                        // Marcar error en el campo de clave nueva 2
                }
                else if (clave_nva2 != clave_nva1)
                {
                    errClaveNva2.Visible = true;                                        // Marcar error en el campo de clave nueva 2
                    errMsj2 += "\r\n La contraseña reingresada no coincide";
                }

                errMsj.Text = "* Completar datos obligatorios" + errMsj2;               // Mostrar mensaje de error
                errMsj.Visible = true;
            }
            //2. Si los datos superan las validaciones controlar que la clave no esté entre las últimas 3 ni la actual
            else
            {
                String[] datos_usuario = pu.EncontrarRegPorColVal("credenciales.csv", 0, usuario);
                //  clave_actual_txt = datos_usuario[1];
                //  intentos_txt = datos_usuario[5];
                //  clave_ant_1 = datos_usuario[6];
                //  clave_ant_2 = datos_usuario[7];
                //  clave_ant_3 = datos_usuario[8];

                // 2.1. Si el usuario no existe da error
                if (datos_usuario.Length == 0)
                {
                    errUsr.Visible = true;                                              // Marcar error en el campo de usuario
                    errMsj.Text = "* Usuario no existente";                             // Mostrar mensaje de error
                    errMsj.Visible = true;
                }
                // 2.2. Si el usuario existe pero la clave está bloqueada da error
                else if (Convert.ToInt32(datos_usuario[5]) >= 3)
                {
                    errUsr.Visible = true;                                              // Marcar error en el campo de usuario
                    errMsj.Text = "* Usuario bloqueado";                                // Mostrar mensaje de error
                    errMsj.Visible = true;
                }
                // 2.3. Si el usuario existe pero la clave es incorrecta da error
                else if (clave_actual != datos_usuario[1])
                {
                    errClaveActual.Visible = true;                                      // Marcar error en el campo de clave nueva 1
                    errMsj.Text = "* Clave incorrecta";                                 // Mostrar mensaje de error
                    errMsj.Visible = true;
                }
                // 2.4. Si usuario y clave son correctos pero la nueva clave no coincide con la reingresada
                else if (clave_nva1 != clave_nva2)
                {
                    errClaveNva2.Visible = true;                                        // Marcar error en el campo de clave nueva 2
                    errMsj.Text = "* La contraseña reingresada no coincide";            // Mostrar mensaje de error
                    errMsj.Visible = true;
                }
                // 2.5. Si la nueva clave coincide con la actual o las ultimas 3
                else if (clave_nva1 == datos_usuario[1] ||
                    clave_nva1 == datos_usuario[6] ||
                    clave_nva1 == datos_usuario[7] ||
                    clave_nva1 == datos_usuario[8])
                {
                    errClaveNva1.Visible = true;                                        // Marcar error en el campo de clave nueva 1
                    errMsj.Text = "* La nueva clave fue utilizada anteriormente";       // Mostrar mensaje de error
                    errMsj.Visible = true;
                }
                // 2.6. Si todo es correcto, cambia la clave,
                //      fechas de modificación y caducidad e intentos
                //      y vuelve al login
                else
                {
                    String[] nuevo_usuario = new string[12];
                    nuevo_usuario[0] = datos_usuario[0];
                    nuevo_usuario[1] = clave_nva1;
                    nuevo_usuario[2] = datos_usuario[2];                                // Fecha de creación
                    nuevo_usuario[3] = DateTime.Now.ToString("yyyy-MM-dd");             // Fecha de modificación
                    nuevo_usuario[4] = DateTime.Now.AddDays(30).ToString("yyyy-MM-dd"); // Fecha de caducidad
                    nuevo_usuario[5] = "0";                                             // Intentos
                    nuevo_usuario[6] = datos_usuario[1];                                // clave-1
                    nuevo_usuario[7] = datos_usuario[6];                                // clave-2
                    nuevo_usuario[8] = datos_usuario[7];                                // clave-3
                    pu.ModificarRegistroCompleto("credenciales.csv", 0, usuario, nuevo_usuario);

                    this.Hide();
                    Login f1 = new Login();
                    f1.ShowDialog();
                }

            }

        }
    }
}
