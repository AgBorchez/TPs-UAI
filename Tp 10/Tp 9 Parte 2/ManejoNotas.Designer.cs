namespace Tp_9_Parte_2
{
    partial class ManejoNotas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerFechaNota = new System.Windows.Forms.DateTimePicker();
            this.ValorNota = new System.Windows.Forms.NumericUpDown();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelDNI = new System.Windows.Forms.Label();
            this.ValorDNI = new System.Windows.Forms.NumericUpDown();
            this.labelNota = new System.Windows.Forms.Label();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.dataGridContenido = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupboxOrdenar = new System.Windows.Forms.GroupBox();
            this.radioButtonFecha = new System.Windows.Forms.RadioButton();
            this.radioButtonNota = new System.Windows.Forms.RadioButton();
            this.radioButtonDNI = new System.Windows.Forms.RadioButton();
            this.BtnOrdenar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValorNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValorDNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContenido)).BeginInit();
            this.GroupboxOrdenar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerFechaNota);
            this.groupBox1.Controls.Add(this.ValorNota);
            this.groupBox1.Controls.Add(this.BtnGuardar);
            this.groupBox1.Controls.Add(this.labelFecha);
            this.groupBox1.Controls.Add(this.labelDNI);
            this.groupBox1.Controls.Add(this.ValorDNI);
            this.groupBox1.Controls.Add(this.labelNota);
            this.groupBox1.Location = new System.Drawing.Point(463, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 200);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePickerFechaNota
            // 
            this.dateTimePickerFechaNota.Location = new System.Drawing.Point(71, 104);
            this.dateTimePickerFechaNota.Name = "dateTimePickerFechaNota";
            this.dateTimePickerFechaNota.Size = new System.Drawing.Size(122, 20);
            this.dateTimePickerFechaNota.TabIndex = 10;
            // 
            // ValorNota
            // 
            this.ValorNota.Location = new System.Drawing.Point(73, 59);
            this.ValorNota.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ValorNota.Name = "ValorNota";
            this.ValorNota.Size = new System.Drawing.Size(120, 20);
            this.ValorNota.TabIndex = 9;
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
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(6, 111);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(37, 13);
            this.labelFecha.TabIndex = 8;
            this.labelFecha.Text = "Fecha";
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
            // ValorDNI
            // 
            this.ValorDNI.Location = new System.Drawing.Point(73, 18);
            this.ValorDNI.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.ValorDNI.Name = "ValorDNI";
            this.ValorDNI.Size = new System.Drawing.Size(120, 20);
            this.ValorDNI.TabIndex = 1;
            // 
            // labelNota
            // 
            this.labelNota.AutoSize = true;
            this.labelNota.Location = new System.Drawing.Point(6, 66);
            this.labelNota.Name = "labelNota";
            this.labelNota.Size = new System.Drawing.Size(30, 13);
            this.labelNota.TabIndex = 0;
            this.labelNota.Text = "Nota";
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Location = new System.Drawing.Point(237, 392);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(198, 51);
            this.BtnBorrar.TabIndex = 9;
            this.BtnBorrar.Text = "Borrar Nota";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(12, 392);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(198, 51);
            this.BtnModificar.TabIndex = 8;
            this.BtnModificar.Text = "Modificar Notas";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // dataGridContenido
            // 
            this.dataGridContenido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridContenido.Location = new System.Drawing.Point(12, 34);
            this.dataGridContenido.Name = "dataGridContenido";
            this.dataGridContenido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridContenido.Size = new System.Drawing.Size(423, 352);
            this.dataGridContenido.TabIndex = 7;
            this.dataGridContenido.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridContenido_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Notas";
            // 
            // GroupboxOrdenar
            // 
            this.GroupboxOrdenar.Controls.Add(this.radioButtonFecha);
            this.GroupboxOrdenar.Controls.Add(this.radioButtonNota);
            this.GroupboxOrdenar.Controls.Add(this.radioButtonDNI);
            this.GroupboxOrdenar.Controls.Add(this.BtnOrdenar);
            this.GroupboxOrdenar.Location = new System.Drawing.Point(591, 248);
            this.GroupboxOrdenar.Name = "GroupboxOrdenar";
            this.GroupboxOrdenar.Size = new System.Drawing.Size(108, 190);
            this.GroupboxOrdenar.TabIndex = 11;
            this.GroupboxOrdenar.TabStop = false;
            this.GroupboxOrdenar.Text = "Ordenar Por:";
            // 
            // radioButtonFecha
            // 
            this.radioButtonFecha.AutoSize = true;
            this.radioButtonFecha.Location = new System.Drawing.Point(25, 74);
            this.radioButtonFecha.Name = "radioButtonFecha";
            this.radioButtonFecha.Size = new System.Drawing.Size(55, 17);
            this.radioButtonFecha.TabIndex = 3;
            this.radioButtonFecha.TabStop = true;
            this.radioButtonFecha.Text = "Fecha";
            this.radioButtonFecha.UseVisualStyleBackColor = true;
            // 
            // radioButtonNota
            // 
            this.radioButtonNota.AutoSize = true;
            this.radioButtonNota.Location = new System.Drawing.Point(25, 51);
            this.radioButtonNota.Name = "radioButtonNota";
            this.radioButtonNota.Size = new System.Drawing.Size(48, 17);
            this.radioButtonNota.TabIndex = 2;
            this.radioButtonNota.TabStop = true;
            this.radioButtonNota.Text = "Nota";
            this.radioButtonNota.UseVisualStyleBackColor = true;
            // 
            // radioButtonDNI
            // 
            this.radioButtonDNI.AutoSize = true;
            this.radioButtonDNI.Location = new System.Drawing.Point(25, 28);
            this.radioButtonDNI.Name = "radioButtonDNI";
            this.radioButtonDNI.Size = new System.Drawing.Size(44, 17);
            this.radioButtonDNI.TabIndex = 1;
            this.radioButtonDNI.TabStop = true;
            this.radioButtonDNI.Text = "DNI";
            this.radioButtonDNI.UseVisualStyleBackColor = true;
            // 
            // BtnOrdenar
            // 
            this.BtnOrdenar.Location = new System.Drawing.Point(25, 144);
            this.BtnOrdenar.Name = "BtnOrdenar";
            this.BtnOrdenar.Size = new System.Drawing.Size(65, 31);
            this.BtnOrdenar.TabIndex = 0;
            this.BtnOrdenar.Text = "Ordenar";
            this.BtnOrdenar.UseVisualStyleBackColor = true;
            this.BtnOrdenar.Click += new System.EventHandler(this.BtnOrdenar_Click);
            // 
            // ManejoNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.GroupboxOrdenar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.dataGridContenido);
            this.Controls.Add(this.label1);
            this.Name = "ManejoNotas";
            this.Text = "ManejoNotas";
            this.Click += new System.EventHandler(this.ManejoNotas_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValorNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValorDNI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContenido)).EndInit();
            this.GroupboxOrdenar.ResumeLayout(false);
            this.GroupboxOrdenar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.NumericUpDown ValorDNI;
        private System.Windows.Forms.Label labelNota;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.DataGridView dataGridContenido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaNota;
        private System.Windows.Forms.NumericUpDown ValorNota;
        private System.Windows.Forms.GroupBox GroupboxOrdenar;
        private System.Windows.Forms.RadioButton radioButtonFecha;
        private System.Windows.Forms.RadioButton radioButtonNota;
        private System.Windows.Forms.RadioButton radioButtonDNI;
        private System.Windows.Forms.Button BtnOrdenar;
    }
}