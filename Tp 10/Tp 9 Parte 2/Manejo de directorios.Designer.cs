namespace Tp_9_Parte_2
{
    partial class Manejo_de_directorios
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
            this.BtnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonNotas = new System.Windows.Forms.RadioButton();
            this.radioButtonAlumnos = new System.Windows.Forms.RadioButton();
            this.BtnModificarContenido = new System.Windows.Forms.Button();
            this.dataGridContenido = new System.Windows.Forms.DataGridView();
            this.BtnCalcularPromedios = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContenido)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(543, 404);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(102, 34);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonNotas);
            this.groupBox1.Controls.Add(this.radioButtonAlumnos);
            this.groupBox1.Location = new System.Drawing.Point(507, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 69);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contenido a cargar:";
            // 
            // radioButtonNotas
            // 
            this.radioButtonNotas.AutoSize = true;
            this.radioButtonNotas.Location = new System.Drawing.Point(14, 42);
            this.radioButtonNotas.Name = "radioButtonNotas";
            this.radioButtonNotas.Size = new System.Drawing.Size(53, 17);
            this.radioButtonNotas.TabIndex = 1;
            this.radioButtonNotas.Text = "Notas";
            this.radioButtonNotas.UseVisualStyleBackColor = true;
            this.radioButtonNotas.Click += new System.EventHandler(this.radioButtonNotas_Click);
            // 
            // radioButtonAlumnos
            // 
            this.radioButtonAlumnos.AutoSize = true;
            this.radioButtonAlumnos.Checked = true;
            this.radioButtonAlumnos.Location = new System.Drawing.Point(14, 19);
            this.radioButtonAlumnos.Name = "radioButtonAlumnos";
            this.radioButtonAlumnos.Size = new System.Drawing.Size(65, 17);
            this.radioButtonAlumnos.TabIndex = 0;
            this.radioButtonAlumnos.TabStop = true;
            this.radioButtonAlumnos.Text = "Alumnos";
            this.radioButtonAlumnos.UseVisualStyleBackColor = true;
            this.radioButtonAlumnos.Click += new System.EventHandler(this.radioButtonAlumnos_Click);
            // 
            // BtnModificarContenido
            // 
            this.BtnModificarContenido.Location = new System.Drawing.Point(435, 404);
            this.BtnModificarContenido.Name = "BtnModificarContenido";
            this.BtnModificarContenido.Size = new System.Drawing.Size(102, 34);
            this.BtnModificarContenido.TabIndex = 6;
            this.BtnModificarContenido.Text = "Modificar Datos";
            this.BtnModificarContenido.UseVisualStyleBackColor = true;
            this.BtnModificarContenido.Click += new System.EventHandler(this.BtnModificarContenido_Click);
            // 
            // dataGridContenido
            // 
            this.dataGridContenido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridContenido.Location = new System.Drawing.Point(8, 12);
            this.dataGridContenido.Name = "dataGridContenido";
            this.dataGridContenido.Size = new System.Drawing.Size(410, 425);
            this.dataGridContenido.TabIndex = 7;
            // 
            // BtnCalcularPromedios
            // 
            this.BtnCalcularPromedios.Location = new System.Drawing.Point(484, 364);
            this.BtnCalcularPromedios.Name = "BtnCalcularPromedios";
            this.BtnCalcularPromedios.Size = new System.Drawing.Size(102, 34);
            this.BtnCalcularPromedios.TabIndex = 8;
            this.BtnCalcularPromedios.Text = "Calcular Promedios";
            this.BtnCalcularPromedios.UseVisualStyleBackColor = true;
            this.BtnCalcularPromedios.Click += new System.EventHandler(this.BtnCalcularPromedios_Click);
            // 
            // Manejo_de_directorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.BtnCalcularPromedios);
            this.Controls.Add(this.dataGridContenido);
            this.Controls.Add(this.BtnModificarContenido);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnSalir);
            this.Name = "Manejo_de_directorios";
            this.Text = "Manejo_de_directorios";
            this.Load += new System.EventHandler(this.Manejo_de_directorios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContenido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonAlumnos;
        private System.Windows.Forms.RadioButton radioButtonNotas;
        private System.Windows.Forms.Button BtnModificarContenido;
        private System.Windows.Forms.DataGridView dataGridContenido;
        private System.Windows.Forms.Button BtnCalcularPromedios;
    }
}