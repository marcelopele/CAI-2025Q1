namespace Facultad
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCambiarClave = new System.Windows.Forms.Button();
            this.errMsj = new System.Windows.Forms.Label();
            this.errPwd = new System.Windows.Forms.Label();
            this.errUsr = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCambiarClave
            // 
            this.btnCambiarClave.Location = new System.Drawing.Point(60, 188);
            this.btnCambiarClave.Name = "btnCambiarClave";
            this.btnCambiarClave.Size = new System.Drawing.Size(100, 23);
            this.btnCambiarClave.TabIndex = 14;
            this.btnCambiarClave.Text = "Cambiar clave";
            this.btnCambiarClave.UseVisualStyleBackColor = true;
            this.btnCambiarClave.Click += new System.EventHandler(this.btnCambiarClave_Click);
            // 
            // errMsj
            // 
            this.errMsj.AutoSize = true;
            this.errMsj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsj.ForeColor = System.Drawing.Color.Red;
            this.errMsj.Location = new System.Drawing.Point(1, 232);
            this.errMsj.Name = "errMsj";
            this.errMsj.Size = new System.Drawing.Size(55, 15);
            this.errMsj.TabIndex = 19;
            this.errMsj.Text = "mensaje";
            this.errMsj.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.errMsj.Visible = false;
            // 
            // errPwd
            // 
            this.errPwd.AutoSize = true;
            this.errPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errPwd.ForeColor = System.Drawing.Color.Red;
            this.errPwd.Location = new System.Drawing.Point(166, 74);
            this.errPwd.Name = "errPwd";
            this.errPwd.Size = new System.Drawing.Size(15, 20);
            this.errPwd.TabIndex = 17;
            this.errPwd.Text = "*";
            this.errPwd.Visible = false;
            // 
            // errUsr
            // 
            this.errUsr.AutoSize = true;
            this.errUsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errUsr.ForeColor = System.Drawing.Color.Red;
            this.errUsr.Location = new System.Drawing.Point(166, 28);
            this.errUsr.Name = "errUsr";
            this.errUsr.Size = new System.Drawing.Size(15, 20);
            this.errUsr.TabIndex = 15;
            this.errUsr.Text = "*";
            this.errUsr.Visible = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(57, 48);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 18;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(57, 96);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 16;
            this.lblClave.Text = "Clave";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(60, 74);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(100, 20);
            this.txtClave.TabIndex = 11;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(60, 25);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 10;
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.Location = new System.Drawing.Point(60, 159);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(100, 23);
            this.btnCrearCuenta.TabIndex = 13;
            this.btnCrearCuenta.Text = "Crear Cuenta";
            this.btnCrearCuenta.UseVisualStyleBackColor = true;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(60, 130);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(100, 23);
            this.btnIngresar.TabIndex = 12;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 254);
            this.Controls.Add(this.btnCambiarClave);
            this.Controls.Add(this.errMsj);
            this.Controls.Add(this.errPwd);
            this.Controls.Add(this.errUsr);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnCrearCuenta);
            this.Controls.Add(this.btnIngresar);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCambiarClave;
        private System.Windows.Forms.Label errMsj;
        private System.Windows.Forms.Label errPwd;
        private System.Windows.Forms.Label errUsr;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.Button btnIngresar;
    }
}

