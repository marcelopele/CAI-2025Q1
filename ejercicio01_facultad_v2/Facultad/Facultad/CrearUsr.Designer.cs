﻿namespace Facultad
{
    partial class CrearUsr
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
            this.errPwd = new System.Windows.Forms.Label();
            this.errUsr = new System.Windows.Forms.Label();
            this.errMail = new System.Windows.Forms.Label();
            this.errApellido = new System.Windows.Forms.Label();
            this.errNombre = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.errMsj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // errPwd
            // 
            this.errPwd.AutoSize = true;
            this.errPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errPwd.ForeColor = System.Drawing.Color.Red;
            this.errPwd.Location = new System.Drawing.Point(366, 130);
            this.errPwd.Name = "errPwd";
            this.errPwd.Size = new System.Drawing.Size(15, 20);
            this.errPwd.TabIndex = 34;
            this.errPwd.Text = "*";
            this.errPwd.Visible = false;
            // 
            // errUsr
            // 
            this.errUsr.AutoSize = true;
            this.errUsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errUsr.ForeColor = System.Drawing.Color.Red;
            this.errUsr.Location = new System.Drawing.Point(366, 104);
            this.errUsr.Name = "errUsr";
            this.errUsr.Size = new System.Drawing.Size(15, 20);
            this.errUsr.TabIndex = 33;
            this.errUsr.Text = "*";
            this.errUsr.Visible = false;
            // 
            // errMail
            // 
            this.errMail.AutoSize = true;
            this.errMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMail.ForeColor = System.Drawing.Color.Red;
            this.errMail.Location = new System.Drawing.Point(366, 78);
            this.errMail.Name = "errMail";
            this.errMail.Size = new System.Drawing.Size(15, 20);
            this.errMail.TabIndex = 32;
            this.errMail.Text = "*";
            this.errMail.Visible = false;
            // 
            // errApellido
            // 
            this.errApellido.AutoSize = true;
            this.errApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errApellido.ForeColor = System.Drawing.Color.Red;
            this.errApellido.Location = new System.Drawing.Point(366, 52);
            this.errApellido.Name = "errApellido";
            this.errApellido.Size = new System.Drawing.Size(15, 20);
            this.errApellido.TabIndex = 31;
            this.errApellido.Text = "*";
            this.errApellido.Visible = false;
            // 
            // errNombre
            // 
            this.errNombre.AutoSize = true;
            this.errNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errNombre.ForeColor = System.Drawing.Color.Red;
            this.errNombre.Location = new System.Drawing.Point(366, 26);
            this.errNombre.Name = "errNombre";
            this.errNombre.Size = new System.Drawing.Size(15, 20);
            this.errNombre.TabIndex = 30;
            this.errNombre.Text = "*";
            this.errNombre.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(205, 183);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(155, 23);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(42, 183);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(155, 23);
            this.btnConfirmar.TabIndex = 23;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Clave";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Usuario";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(39, 81);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(31, 13);
            this.lblMail.TabIndex = 27;
            this.lblMail.Text = "email";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(39, 55);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 26;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(39, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 24;
            this.lblNombre.Text = "Nombre";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(110, 130);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(250, 20);
            this.txtClave.TabIndex = 22;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(110, 104);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(250, 20);
            this.txtUsuario.TabIndex = 21;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(110, 78);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(250, 20);
            this.txtMail.TabIndex = 20;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(110, 52);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(250, 20);
            this.txtApellido.TabIndex = 19;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(110, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 20);
            this.txtNombre.TabIndex = 18;
            // 
            // errMsj
            // 
            this.errMsj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsj.ForeColor = System.Drawing.Color.Red;
            this.errMsj.Location = new System.Drawing.Point(18, 170);
            this.errMsj.Name = "errMsj";
            this.errMsj.Size = new System.Drawing.Size(370, 88);
            this.errMsj.TabIndex = 35;
            this.errMsj.Text = "mensaje";
            this.errMsj.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.errMsj.Visible = false;
            // 
            // CrearUsr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 273);
            this.Controls.Add(this.errPwd);
            this.Controls.Add(this.errUsr);
            this.Controls.Add(this.errMail);
            this.Controls.Add(this.errApellido);
            this.Controls.Add(this.errNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.errMsj);
            this.Name = "CrearUsr";
            this.Text = "CrearUsr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label errPwd;
        private System.Windows.Forms.Label errUsr;
        private System.Windows.Forms.Label errMail;
        private System.Windows.Forms.Label errApellido;
        private System.Windows.Forms.Label errNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label errMsj;
    }
}