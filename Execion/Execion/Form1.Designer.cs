namespace Execion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.B1 = new System.Windows.Forms.Button();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.Lbl_Matricula = new System.Windows.Forms.Label();
            this.txt_Matricula = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Semestre = new System.Windows.Forms.Label();
            this.txt_Semestre = new System.Windows.Forms.TextBox();
            this.lbl_Carrera = new System.Windows.Forms.Label();
            this.txt_Carrera = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_Calificacion = new System.Windows.Forms.Label();
            this.txt_Calificacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(221, 272);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 23);
            this.B1.TabIndex = 0;
            this.B1.Text = "Aceptar";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(308, 226);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(100, 20);
            this.txt_Telefono.TabIndex = 1;
            this.txt_Telefono.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Lbl_Matricula
            // 
            this.Lbl_Matricula.AutoSize = true;
            this.Lbl_Matricula.Location = new System.Drawing.Point(218, 30);
            this.Lbl_Matricula.Name = "Lbl_Matricula";
            this.Lbl_Matricula.Size = new System.Drawing.Size(50, 13);
            this.Lbl_Matricula.TabIndex = 2;
            this.Lbl_Matricula.Text = "&Matricula";
            // 
            // txt_Matricula
            // 
            this.txt_Matricula.Location = new System.Drawing.Point(308, 23);
            this.txt_Matricula.Name = "txt_Matricula";
            this.txt_Matricula.Size = new System.Drawing.Size(100, 20);
            this.txt_Matricula.TabIndex = 3;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(218, 81);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nombre.TabIndex = 4;
            this.lbl_Nombre.Text = "&Nombre";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(308, 74);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 5;
            // 
            // lbl_Semestre
            // 
            this.lbl_Semestre.AutoSize = true;
            this.lbl_Semestre.Location = new System.Drawing.Point(218, 135);
            this.lbl_Semestre.Name = "lbl_Semestre";
            this.lbl_Semestre.Size = new System.Drawing.Size(51, 13);
            this.lbl_Semestre.TabIndex = 6;
            this.lbl_Semestre.Text = "&Semestre";
            // 
            // txt_Semestre
            // 
            this.txt_Semestre.Location = new System.Drawing.Point(308, 128);
            this.txt_Semestre.Name = "txt_Semestre";
            this.txt_Semestre.Size = new System.Drawing.Size(100, 20);
            this.txt_Semestre.TabIndex = 7;
            // 
            // lbl_Carrera
            // 
            this.lbl_Carrera.AutoSize = true;
            this.lbl_Carrera.Location = new System.Drawing.Point(218, 183);
            this.lbl_Carrera.Name = "lbl_Carrera";
            this.lbl_Carrera.Size = new System.Drawing.Size(41, 13);
            this.lbl_Carrera.TabIndex = 8;
            this.lbl_Carrera.Text = "&Carrera";
            // 
            // txt_Carrera
            // 
            this.txt_Carrera.Location = new System.Drawing.Point(308, 176);
            this.txt_Carrera.Name = "txt_Carrera";
            this.txt_Carrera.Size = new System.Drawing.Size(100, 20);
            this.txt_Carrera.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "&Telefono";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbl_Calificacion
            // 
            this.lbl_Calificacion.AutoSize = true;
            this.lbl_Calificacion.Location = new System.Drawing.Point(12, 233);
            this.lbl_Calificacion.Name = "lbl_Calificacion";
            this.lbl_Calificacion.Size = new System.Drawing.Size(64, 13);
            this.lbl_Calificacion.TabIndex = 12;
            this.lbl_Calificacion.Text = "&Calificacion:";
            // 
            // txt_Calificacion
            // 
            this.txt_Calificacion.Location = new System.Drawing.Point(88, 229);
            this.txt_Calificacion.Name = "txt_Calificacion";
            this.txt_Calificacion.Size = new System.Drawing.Size(100, 20);
            this.txt_Calificacion.TabIndex = 13;
            this.txt_Calificacion.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Calificacion_Validating);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 349);
            this.Controls.Add(this.txt_Calificacion);
            this.Controls.Add(this.lbl_Calificacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Carrera);
            this.Controls.Add(this.lbl_Carrera);
            this.Controls.Add(this.txt_Semestre);
            this.Controls.Add(this.lbl_Semestre);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.txt_Matricula);
            this.Controls.Add(this.Lbl_Matricula);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.B1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.Label Lbl_Matricula;
        private System.Windows.Forms.TextBox txt_Matricula;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_Semestre;
        private System.Windows.Forms.TextBox txt_Semestre;
        private System.Windows.Forms.Label lbl_Carrera;
        private System.Windows.Forms.TextBox txt_Carrera;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txt_Calificacion;
        private System.Windows.Forms.Label lbl_Calificacion;
    }
}

