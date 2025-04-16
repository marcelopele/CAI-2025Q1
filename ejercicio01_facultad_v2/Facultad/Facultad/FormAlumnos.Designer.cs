namespace Facultad
{
    partial class FormAlumnos
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
            this.txtModo = new System.Windows.Forms.TextBox();
            this.txtFechaNacReadOnly = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.btnNombreCompleto = new System.Windows.Forms.Button();
            this.btnCredencial = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblFhNacimiento = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtFechaNac = new System.Windows.Forms.DateTimePicker();
            this.btnSaludo = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lstAlumnos = new System.Windows.Forms.ListBox();
            this.errMsj = new System.Windows.Forms.Label();
            this.grdReporteAlu = new System.Windows.Forms.DataGridView();
            this.carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matApr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matPen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcRestante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdReporteAlu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtModo
            // 
            this.txtModo.Location = new System.Drawing.Point(5, 4);
            this.txtModo.Name = "txtModo";
            this.txtModo.ReadOnly = true;
            this.txtModo.Size = new System.Drawing.Size(30, 20);
            this.txtModo.TabIndex = 37;
            this.txtModo.Visible = false;
            // 
            // txtFechaNacReadOnly
            // 
            this.txtFechaNacReadOnly.Location = new System.Drawing.Point(141, 81);
            this.txtFechaNacReadOnly.Name = "txtFechaNacReadOnly";
            this.txtFechaNacReadOnly.ReadOnly = true;
            this.txtFechaNacReadOnly.Size = new System.Drawing.Size(220, 20);
            this.txtFechaNacReadOnly.TabIndex = 36;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(435, 146);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(61, 23);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(368, 146);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(61, 23);
            this.btnConfirmar.TabIndex = 32;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Visible = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(28, 146);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(107, 23);
            this.btnNuevo.TabIndex = 28;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(254, 146);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 23);
            this.btnEliminar.TabIndex = 31;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(141, 146);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(107, 23);
            this.btnModificar.TabIndex = 30;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.Location = new System.Drawing.Point(367, 30);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(129, 23);
            this.btnVolverMenu.TabIndex = 24;
            this.btnVolverMenu.Text = "Volver al Menú";
            this.btnVolverMenu.UseVisualStyleBackColor = true;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // btnNombreCompleto
            // 
            this.btnNombreCompleto.Location = new System.Drawing.Point(367, 82);
            this.btnNombreCompleto.Name = "btnNombreCompleto";
            this.btnNombreCompleto.Size = new System.Drawing.Size(129, 23);
            this.btnNombreCompleto.TabIndex = 26;
            this.btnNombreCompleto.Text = "Nombre Completo";
            this.btnNombreCompleto.UseVisualStyleBackColor = true;
            this.btnNombreCompleto.Click += new System.EventHandler(this.btnNombreCompleto_Click);
            // 
            // btnCredencial
            // 
            this.btnCredencial.Location = new System.Drawing.Point(367, 56);
            this.btnCredencial.Name = "btnCredencial";
            this.btnCredencial.Size = new System.Drawing.Size(129, 23);
            this.btnCredencial.TabIndex = 25;
            this.btnCredencial.Text = "Credencial";
            this.btnCredencial.UseVisualStyleBackColor = true;
            this.btnCredencial.Click += new System.EventHandler(this.btnCredencial_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(141, 108);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(220, 20);
            this.txtCodigo.TabIndex = 22;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(27, 111);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 34;
            this.lblCodigo.Text = "Código";
            // 
            // lblFhNacimiento
            // 
            this.lblFhNacimiento.AutoSize = true;
            this.lblFhNacimiento.Location = new System.Drawing.Point(27, 84);
            this.lblFhNacimiento.Name = "lblFhNacimiento";
            this.lblFhNacimiento.Size = new System.Drawing.Size(108, 13);
            this.lblFhNacimiento.TabIndex = 33;
            this.lblFhNacimiento.Text = "Fecha de Nacimiento";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(141, 56);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ReadOnly = true;
            this.txtApellido.Size = new System.Drawing.Size(220, 20);
            this.txtApellido.TabIndex = 20;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(27, 59);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 29;
            this.lblApellido.Text = "Apellido";
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.Location = new System.Drawing.Point(141, 82);
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.Size = new System.Drawing.Size(220, 20);
            this.txtFechaNac.TabIndex = 21;
            this.txtFechaNac.Visible = false;
            // 
            // btnSaludo
            // 
            this.btnSaludo.Location = new System.Drawing.Point(367, 108);
            this.btnSaludo.Name = "btnSaludo";
            this.btnSaludo.Size = new System.Drawing.Size(129, 23);
            this.btnSaludo.TabIndex = 27;
            this.btnSaludo.Text = "Saludo informal";
            this.btnSaludo.UseVisualStyleBackColor = true;
            this.btnSaludo.Click += new System.EventHandler(this.btnSaludo_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(141, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(220, 20);
            this.txtNombre.TabIndex = 19;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(27, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 23;
            this.lblNombre.Text = "Nombre";
            // 
            // lstAlumnos
            // 
            this.lstAlumnos.FormattingEnabled = true;
            this.lstAlumnos.Location = new System.Drawing.Point(502, 27);
            this.lstAlumnos.Name = "lstAlumnos";
            this.lstAlumnos.Size = new System.Drawing.Size(227, 394);
            this.lstAlumnos.TabIndex = 39;
            this.lstAlumnos.Click += new System.EventHandler(this.lstAlumnos_Click);
            // 
            // errMsj
            // 
            this.errMsj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsj.ForeColor = System.Drawing.Color.Red;
            this.errMsj.Location = new System.Drawing.Point(2, 160);
            this.errMsj.Name = "errMsj";
            this.errMsj.Size = new System.Drawing.Size(510, 27);
            this.errMsj.TabIndex = 99;
            this.errMsj.Text = "mensaje";
            this.errMsj.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.errMsj.Visible = false;
            // 
            // grdReporteAlu
            // 
            this.grdReporteAlu.AllowUserToAddRows = false;
            this.grdReporteAlu.AllowUserToDeleteRows = false;
            this.grdReporteAlu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdReporteAlu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carrera,
            this.matApr,
            this.matPen,
            this.porcRestante});
            this.grdReporteAlu.Location = new System.Drawing.Point(28, 190);
            this.grdReporteAlu.Name = "grdReporteAlu";
            this.grdReporteAlu.ReadOnly = true;
            this.grdReporteAlu.Size = new System.Drawing.Size(468, 230);
            this.grdReporteAlu.TabIndex = 100;
            // 
            // carrera
            // 
            this.carrera.HeaderText = "Carrera";
            this.carrera.Name = "carrera";
            this.carrera.ReadOnly = true;
            // 
            // matApr
            // 
            this.matApr.HeaderText = "Materias Aprobadas";
            this.matApr.Name = "matApr";
            this.matApr.ReadOnly = true;
            // 
            // matPen
            // 
            this.matPen.HeaderText = "Materias Pendientes";
            this.matPen.Name = "matPen";
            this.matPen.ReadOnly = true;
            // 
            // porcRestante
            // 
            this.porcRestante.HeaderText = "Porcentaje Restante";
            this.porcRestante.Name = "porcRestante";
            this.porcRestante.ReadOnly = true;
            // 
            // FormAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 442);
            this.Controls.Add(this.grdReporteAlu);
            this.Controls.Add(this.lstAlumnos);
            this.Controls.Add(this.txtModo);
            this.Controls.Add(this.txtFechaNacReadOnly);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.btnNombreCompleto);
            this.Controls.Add(this.btnCredencial);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblFhNacimiento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtFechaNac);
            this.Controls.Add(this.btnSaludo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.errMsj);
            this.Name = "FormAlumnos";
            this.Text = "FormAlumnos";
            ((System.ComponentModel.ISupportInitialize)(this.grdReporteAlu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtModo;
        private System.Windows.Forms.TextBox txtFechaNacReadOnly;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnVolverMenu;
        private System.Windows.Forms.Button btnNombreCompleto;
        private System.Windows.Forms.Button btnCredencial;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblFhNacimiento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.DateTimePicker txtFechaNac;
        private System.Windows.Forms.Button btnSaludo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ListBox lstAlumnos;
        private System.Windows.Forms.Label errMsj;
        private System.Windows.Forms.DataGridView grdReporteAlu;
        private System.Windows.Forms.DataGridViewTextBoxColumn carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn matApr;
        private System.Windows.Forms.DataGridViewTextBoxColumn matPen;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcRestante;
    }
}