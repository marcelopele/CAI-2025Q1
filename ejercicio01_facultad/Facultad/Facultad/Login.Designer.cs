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
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.errUsr = new System.Windows.Forms.Label();
            this.errPwd = new System.Windows.Forms.Label();
            this.errMsj = new System.Windows.Forms.Label();
            this.btnCambiarClave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(71, 147);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(100, 23);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.Location = new System.Drawing.Point(71, 176);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(100, 23);
            this.btnCrearCuenta.TabIndex = 3;
            this.btnCrearCuenta.Text = "Crear Cuenta";
            this.btnCrearCuenta.UseVisualStyleBackColor = true;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(71, 42);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(71, 91);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(100, 20);
            this.txtClave.TabIndex = 1;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(68, 113);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 5;
            this.lblClave.Text = "Clave";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(68, 65);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Usuario";
            // 
            // errUsr
            // 
            this.errUsr.AutoSize = true;
            this.errUsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errUsr.ForeColor = System.Drawing.Color.Red;
            this.errUsr.Location = new System.Drawing.Point(177, 45);
            this.errUsr.Name = "errUsr";
            this.errUsr.Size = new System.Drawing.Size(15, 20);
            this.errUsr.TabIndex = 5;
            this.errUsr.Text = "*";
            this.errUsr.Visible = false;
            // 
            // errPwd
            // 
            this.errPwd.AutoSize = true;
            this.errPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errPwd.ForeColor = System.Drawing.Color.Red;
            this.errPwd.Location = new System.Drawing.Point(177, 91);
            this.errPwd.Name = "errPwd";
            this.errPwd.Size = new System.Drawing.Size(15, 20);
            this.errPwd.TabIndex = 6;
            this.errPwd.Text = "*";
            this.errPwd.Visible = false;
            // 
            // errMsj
            // 
            this.errMsj.AutoSize = true;
            this.errMsj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsj.ForeColor = System.Drawing.Color.Red;
            this.errMsj.Location = new System.Drawing.Point(12, 249);
            this.errMsj.Name = "errMsj";
            this.errMsj.Size = new System.Drawing.Size(55, 15);
            this.errMsj.TabIndex = 9;
            this.errMsj.Text = "mensaje";
            this.errMsj.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.errMsj.Visible = false;
            // 
            // btnCambiarClave
            // 
            this.btnCambiarClave.Location = new System.Drawing.Point(71, 205);
            this.btnCambiarClave.Name = "btnCambiarClave";
            this.btnCambiarClave.Size = new System.Drawing.Size(100, 23);
            this.btnCambiarClave.TabIndex = 4;
            this.btnCambiarClave.Text = "Cambiar clave";
            this.btnCambiarClave.UseVisualStyleBackColor = true;
            this.btnCambiarClave.Click += new System.EventHandler(this.btnCambiarClave_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 273);
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
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label errUsr;
        private System.Windows.Forms.Label errPwd;
        private System.Windows.Forms.Label errMsj;
        private System.Windows.Forms.Button btnCambiarClave;
    }
}

