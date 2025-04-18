namespace Facultad
{
    partial class FormReportes
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
            this.textAlumno = new System.Windows.Forms.TextBox();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textAlumno
            // 
            this.textAlumno.Location = new System.Drawing.Point(39, 49);
            this.textAlumno.Name = "textAlumno";
            this.textAlumno.Size = new System.Drawing.Size(100, 20);
            this.textAlumno.TabIndex = 0;
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(39, 30);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(42, 13);
            this.lblAlumno.TabIndex = 1;
            this.lblAlumno.Text = "Alumno";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(39, 76);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(100, 23);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Respuesta 1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(39, 105);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(100, 23);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "Respuesta 2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(39, 134);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(100, 23);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "Respuesta 4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(180, 25);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(100, 23);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "Respuesta 3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.Location = new System.Drawing.Point(180, 176);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(100, 23);
            this.btnVolverMenu.TabIndex = 25;
            this.btnVolverMenu.Text = "Volver al Menú";
            this.btnVolverMenu.UseVisualStyleBackColor = true;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 211);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.textAlumno);
            this.Name = "FormReportes";
            this.Text = "FormReportes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textAlumno;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnVolverMenu;
    }
}