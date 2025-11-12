namespace Tp_9_Parte_2
{
    partial class ManejoAlumnos
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridContenido = new System.Windows.Forms.DataGridView();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelDNI = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelNombre = new System.Windows.Forms.Label();
            this.GroupboxOrdenar = new System.Windows.Forms.GroupBox();
            this.radioButtonApellido = new System.Windows.Forms.RadioButton();
            this.radioButtonNombre = new System.Windows.Forms.RadioButton();
            this.radioButtonDNI = new System.Windows.Forms.RadioButton();
            this.BtnOrdenar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContenido)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.GroupboxOrdenar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alumnos";
            // 
            // dataGridContenido
            // 
            this.dataGridContenido.AllowUserToAddRows = false;
            this.dataGridContenido.AllowUserToDeleteRows = false;
            this.dataGridContenido.AllowUserToResizeColumns = false;
            this.dataGridContenido.AllowUserToResizeRows = false;
            this.dataGridContenido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridContenido.Location = new System.Drawing.Point(5, 29);
            this.dataGridContenido.Name = "dataGridContenido";
            this.dataGridContenido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridContenido.Size = new System.Drawing.Size(423, 352);
            this.dataGridContenido.TabIndex = 1;
            this.dataGridContenido.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridContenido_CellMouseClick);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(5, 387);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(198, 51);
            this.BtnModificar.TabIndex = 2;
            this.BtnModificar.Text = "Modificar Alumno";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Location = new System.Drawing.Point(230, 387);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(198, 51);
            this.BtnBorrar.TabIndex = 3;
            this.BtnBorrar.Text = "Borrar alumno";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(73, 154);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(120, 26);
            this.BtnGuardar.TabIndex = 4;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxApellido);
            this.groupBox1.Controls.Add(this.BtnGuardar);
            this.groupBox1.Controls.Add(this.labelApellido);
            this.groupBox1.Controls.Add(this.labelDNI);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.labelNombre);
            this.groupBox1.Location = new System.Drawing.Point(444, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 200);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(73, 104);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(120, 20);
            this.textBoxApellido.TabIndex = 9;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(6, 111);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(44, 13);
            this.labelApellido.TabIndex = 8;
            this.labelApellido.Text = "Apellido";
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Location = new System.Drawing.Point(6, 25);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(26, 13);
            this.labelDNI.TabIndex = 7;
            this.labelDNI.Text = "DNI";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(73, 63);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(120, 20);
            this.textBoxNombre.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(73, 18);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(6, 66);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // GroupboxOrdenar
            // 
            this.GroupboxOrdenar.Controls.Add(this.radioButtonApellido);
            this.GroupboxOrdenar.Controls.Add(this.radioButtonNombre);
            this.GroupboxOrdenar.Controls.Add(this.radioButtonDNI);
            this.GroupboxOrdenar.Controls.Add(this.BtnOrdenar);
            this.GroupboxOrdenar.Location = new System.Drawing.Point(585, 235);
            this.GroupboxOrdenar.Name = "GroupboxOrdenar";
            this.GroupboxOrdenar.Size = new System.Drawing.Size(95, 203);
            this.GroupboxOrdenar.TabIndex = 6;
            this.GroupboxOrdenar.TabStop = false;
            this.GroupboxOrdenar.Text = "Ordenar Por:";
            // 
            // radioButtonApellido
            // 
            this.radioButtonApellido.AutoSize = true;
            this.radioButtonApellido.Location = new System.Drawing.Point(9, 81);
            this.radioButtonApellido.Name = "radioButtonApellido";
            this.radioButtonApellido.Size = new System.Drawing.Size(62, 17);
            this.radioButtonApellido.TabIndex = 3;
            this.radioButtonApellido.TabStop = true;
            this.radioButtonApellido.Text = "Apellido";
            this.radioButtonApellido.UseVisualStyleBackColor = true;
            // 
            // radioButtonNombre
            // 
            this.radioButtonNombre.AutoSize = true;
            this.radioButtonNombre.Location = new System.Drawing.Point(9, 58);
            this.radioButtonNombre.Name = "radioButtonNombre";
            this.radioButtonNombre.Size = new System.Drawing.Size(62, 17);
            this.radioButtonNombre.TabIndex = 2;
            this.radioButtonNombre.TabStop = true;
            this.radioButtonNombre.Text = "Nombre";
            this.radioButtonNombre.UseVisualStyleBackColor = true;
            // 
            // radioButtonDNI
            // 
            this.radioButtonDNI.AutoSize = true;
            this.radioButtonDNI.Location = new System.Drawing.Point(9, 35);
            this.radioButtonDNI.Name = "radioButtonDNI";
            this.radioButtonDNI.Size = new System.Drawing.Size(44, 17);
            this.radioButtonDNI.TabIndex = 1;
            this.radioButtonDNI.TabStop = true;
            this.radioButtonDNI.Text = "DNI";
            this.radioButtonDNI.UseVisualStyleBackColor = true;
            // 
            // BtnOrdenar
            // 
            this.BtnOrdenar.Location = new System.Drawing.Point(9, 152);
            this.BtnOrdenar.Name = "BtnOrdenar";
            this.BtnOrdenar.Size = new System.Drawing.Size(70, 41);
            this.BtnOrdenar.TabIndex = 0;
            this.BtnOrdenar.Text = "Ordenar";
            this.BtnOrdenar.UseVisualStyleBackColor = true;
            this.BtnOrdenar.Click += new System.EventHandler(this.BtnOrdenar_Click);
            // 
            // ManejoAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.GroupboxOrdenar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.dataGridContenido);
            this.Controls.Add(this.label1);
            this.Name = "ManejoAlumnos";
            this.Text = "ManejoAlumnos";
            this.Load += new System.EventHandler(this.ManejoAlumnos_Load);
            this.Click += new System.EventHandler(this.ManejoAlumnos_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContenido)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.GroupboxOrdenar.ResumeLayout(false);
            this.GroupboxOrdenar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridContenido;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.GroupBox GroupboxOrdenar;
        private System.Windows.Forms.Button BtnOrdenar;
        private System.Windows.Forms.RadioButton radioButtonApellido;
        private System.Windows.Forms.RadioButton radioButtonNombre;
        private System.Windows.Forms.RadioButton radioButtonDNI;
    }
}