namespace GestorRegistroDeAlumnosYDocentes.WF
{
    partial class FormInicio
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblRol = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.lblSemestre = new System.Windows.Forms.Label();
            this.txtSemestre = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstPersonal = new System.Windows.Forms.ListBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRol
            // 
            this.lblRol.Location = new System.Drawing.Point(12, 15);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(100, 23);
            this.lblRol.Text = "Rol:";
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.Items.AddRange(new object[] { "Alumno", "Docente" });
            this.cmbRol.Location = new System.Drawing.Point(118, 12);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(200, 23);
            // 
            // lblMatricula
            // 
            this.lblMatricula.Location = new System.Drawing.Point(12, 44);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(100, 23);
            this.lblMatricula.Text = "Matrícula:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(118, 41);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(200, 23);
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(12, 73);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 23);
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(118, 70);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 23);
            // 
            // lblCarrera
            // 
            this.lblCarrera.Location = new System.Drawing.Point(12, 102);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(100, 23);
            this.lblCarrera.Text = "Carrera:";
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(118, 99);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(200, 23);
            // 
            // lblSemestre
            // 
            this.lblSemestre.Location = new System.Drawing.Point(12, 131);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(100, 23);
            this.lblSemestre.Text = "Semestre:";
            // 
            // txtSemestre
            // 
            this.txtSemestre.Location = new System.Drawing.Point(118, 128);
            this.txtSemestre.Name = "txtSemestre";
            this.txtSemestre.Size = new System.Drawing.Size(200, 23);
            // 
            // lblCorreo
            // 
            this.lblCorreo.Location = new System.Drawing.Point(12, 160);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(100, 23);
            this.lblCorreo.Text = "Correo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(118, 157);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(200, 23);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(118, 186);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(200, 30);
            this.btnAgregar.Text = "Agregar Personal";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstPersonal
            // 
            this.lstPersonal.FormattingEnabled = true;
            this.lstPersonal.ItemHeight = 15;
            this.lstPersonal.Location = new System.Drawing.Point(340, 12);
            this.lstPersonal.Name = "lstPersonal";
            this.lstPersonal.Size = new System.Drawing.Size(350, 244);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(340, 265);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 30);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FormInicio
            // 
            this.ClientSize = new System.Drawing.Size(714, 311);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lstPersonal);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtSemestre);
            this.Controls.Add(this.lblSemestre);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.lblRol);
            this.Name = "FormInicio";
            this.Text = "Gestor de Alumnos y Docentes";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.TextBox txtSemestre;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstPersonal;
        private System.Windows.Forms.Button btnEliminar;
    }
}
