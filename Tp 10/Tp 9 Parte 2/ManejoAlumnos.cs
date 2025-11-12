using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_9_Parte_2
{
    public partial class ManejoAlumnos : Form
    {
        internal List<Alumnos> ContenidoEnPantallaAlumnos = new List<Alumnos>();
        private void LlenarDataGrid(List<Alumnos> lista)
        {
            dataGridContenido.DataSource = null;
            dataGridContenido.DataSource = lista;
            dataGridContenido.Columns[0].HeaderText = "DNI";
            dataGridContenido.Columns[1].HeaderText = "Nombre";
            dataGridContenido.Columns[2].HeaderText = "Apellido";
        }

        private void RefrescoDataGrid()
        {
            ContenidoEnPantallaAlumnos.Clear();
            FileStream fs = new FileStream("alumnos.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            using (StreamReader sr = new StreamReader(fs))
            {
                string linea = sr.ReadLine();

                while (linea != null)
                {
                    ContenidoEnPantallaAlumnos.Add(new Alumnos(linea));
                    linea = sr.ReadLine();
                }
            }
            fs.Close();
            LlenarDataGrid(ContenidoEnPantallaAlumnos);
        }

        public ManejoAlumnos()
        {
            InitializeComponent();
        }

        private void Escritura()
        {
            FileStream fs = new FileStream("alumnos.txt", FileMode.OpenOrCreate, FileAccess.Write);

            using (StreamWriter sw = new StreamWriter(fs))
            {
                foreach (Alumnos item in ContenidoEnPantallaAlumnos)
                {
                    sw.WriteLine(Alumnos.GenerarRegistro(item));
                }
            }
            fs.Close();
        }

        private void ManejoAlumnos_Load(object sender, EventArgs e)
        {
            RefrescoDataGrid();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("alumnos.txt", FileMode.Append, FileAccess.Write);

            using (StreamWriter sw = new StreamWriter(fs))
            {
                Alumnos AlumnoNuevo = new Alumnos(numericUpDown1.Value, textBoxNombre.Text, textBoxApellido.Text);
                sw.WriteLine(Alumnos.GenerarRegistro(AlumnoNuevo));
            }

            fs.Close();

            RefrescoDataGrid();


        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if(dataGridContenido.SelectedRows.Count > 0)
            {
                Alumnos alumnoSeleccionado = (Alumnos)dataGridContenido.SelectedRows[0].DataBoundItem;
                FileStream fs = new FileStream("alumnos.txt", FileMode.OpenOrCreate, FileAccess.Read);
                FileStream aux = new FileStream("alumnosaux.txt", FileMode.OpenOrCreate, FileAccess.Write);

                using (StreamReader sr = new StreamReader(fs))
                {
                    using (StreamWriter sw = new StreamWriter(aux))
                    {
                        string linea = sr.ReadLine();
                        while(linea != null)
                        {
                            if(linea != Alumnos.GenerarRegistro(alumnoSeleccionado))
                            {
                                sw.WriteLine(linea);
                            }
                            linea = sr.ReadLine();
                        }
                    }
                }

                fs.Close();
                aux.Close();

                File.Delete("alumnos.txt");
                File.Move("alumnosaux.txt", "alumnos.txt");

                RefrescoDataGrid();
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridContenido.SelectedRows.Count > 0)
            {
                Alumnos alumnoSeleccionado = (Alumnos)dataGridContenido.SelectedRows[0].DataBoundItem;
                Alumnos NuevoAlumno = new Alumnos(numericUpDown1.Value, textBoxNombre.Text, textBoxApellido.Text);

                FileStream fs = new FileStream("alumnos.txt", FileMode.OpenOrCreate, FileAccess.Read);
                FileStream aux = new FileStream("alumnosaux.txt", FileMode.OpenOrCreate, FileAccess.Write);

                using (StreamReader sr = new StreamReader(fs))
                {
                    using (StreamWriter sw = new StreamWriter(aux))
                    {
                        string linea = sr.ReadLine();
                        while (linea != null)
                        {
                            Alumnos LineaActual = new Alumnos(linea);
                            if (LineaActual.DNI != alumnoSeleccionado.DNI)
                            {
                                sw.WriteLine(linea);
                            }
                            else
                            {
                                sw.WriteLine(Alumnos.GenerarRegistro(NuevoAlumno));
                            }
                            linea = sr.ReadLine();
                        }
                    }
                }

                fs.Close();
                aux.Close();

                File.Delete("alumnos.txt");
                File.Move("alumnosaux.txt", "alumnos.txt");

                RefrescoDataGrid();
            }
        }

        private void dataGridContenido_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridContenido.SelectedRows.Count > 0)
            {
                Alumnos alumnoSeleccionado = (Alumnos)dataGridContenido.SelectedRows[0].DataBoundItem;

                numericUpDown1.Value = alumnoSeleccionado.DNI;
                numericUpDown1.Enabled = false;
                textBoxNombre.Text = $"{alumnoSeleccionado.Nombre}";
                textBoxApellido.Text = $"{alumnoSeleccionado.Apellido}";
            }
        }

        private void ManejoAlumnos_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            numericUpDown1.Enabled = true;
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
        }

        private void BtnOrdenar_Click(object sender, EventArgs e)
        {
            if (radioButtonDNI.Checked)
            {
                ContenidoEnPantallaAlumnos = ContenidoEnPantallaAlumnos.OrderBy(a => a.DNI).ToList();
                Escritura();
            }
            if (radioButtonNombre.Checked)
            {
                ContenidoEnPantallaAlumnos = ContenidoEnPantallaAlumnos.OrderBy(a => a.Nombre).ToList();
                Escritura();
            }
            if (radioButtonApellido.Checked)
            {
                ContenidoEnPantallaAlumnos = ContenidoEnPantallaAlumnos.OrderBy(a => a.Apellido).ToList();
                Escritura();
            }

            RefrescoDataGrid();
        }
    }
}
