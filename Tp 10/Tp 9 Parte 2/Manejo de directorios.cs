using System;
using System.Collections;
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
    public partial class Manejo_de_directorios : Form
    {
        private List<Notas> ContenidoEnPantallaNotas = new List<Notas>();
        private List<Alumnos> ContenidoEnPantallaAlumnos = new List<Alumnos>();
        private string ContenidoEnPantalla; Alumnos AlumnoActual; Notas NotaActual;

        private void LlenarDataGridAlumnos()
        {
            CargarListaAlumnos();
            dataGridContenido.DataSource = null;
            dataGridContenido.DataSource = ContenidoEnPantallaAlumnos;
            dataGridContenido.Columns[0].HeaderText = "DNI";
            dataGridContenido.Columns[1].HeaderText = "Nombre";
            dataGridContenido.Columns[2].HeaderText = "Apellido";
            dataGridContenido.Columns[3].HeaderText = "Promedio";

        }

        private void CargarListaAlumnos()
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
        }

        private void LlenarDataGridNotas()
        {
            CargarListaNotas();
            dataGridContenido.DataSource = null;
            dataGridContenido.DataSource = ContenidoEnPantallaNotas;
            dataGridContenido.Columns[0].HeaderText = "DNI";
            dataGridContenido.Columns[1].HeaderText = "Nota";
            dataGridContenido.Columns[2].HeaderText = "Fecha";
        }

        private void CargarListaNotas()
        {
            ContenidoEnPantallaNotas.Clear();
            FileStream fs = new FileStream("notas.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            using (StreamReader sr = new StreamReader(fs))
            {
                string linea = sr.ReadLine();

                while (linea != null)
                {
                    ContenidoEnPantallaNotas.Add(new Notas(linea));
                    linea = sr.ReadLine();
                }
            }

            fs.Close();
        }
        public Manejo_de_directorios()
        {
            InitializeComponent();
            LlenarDataGridAlumnos();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Manejo_de_directorios_Load(object sender, EventArgs e)
        {
        }

        private void BtnModificarContenido_Click(object sender, EventArgs e)
        {
            if (radioButtonAlumnos.Checked) 
            {
                using(ManejoAlumnos form = new ManejoAlumnos())
                {
                    form.ShowDialog();
                    LlenarDataGridAlumnos();
                }
                
            }

            if (radioButtonNotas.Checked) 
            {
                using (ManejoNotas form = new ManejoNotas())
                {
                    form.ShowDialog();
                    LlenarDataGridNotas();
                }
                
            }
        }

        private void radioButtonAlumnos_Click(object sender, EventArgs e)
        {
            
            LlenarDataGridAlumnos();
        }

        private void radioButtonNotas_Click(object sender, EventArgs e)
        {
            
            LlenarDataGridNotas();
        }

        private void BtnCalcularPromedios_Click(object sender, EventArgs e)
        {
            FileStream fsAlumnos = new FileStream("alumnos.txt", FileMode.OpenOrCreate, FileAccess.Read);
            FileStream fsNotas = new FileStream("notas.txt", FileMode.OpenOrCreate, FileAccess.Read);
            FileStream aux = new FileStream("alumnosaux.txt", FileMode.OpenOrCreate, FileAccess.Write);
            string lineaAlumnos, lineaNotas; 


            using (StreamReader srAlumnos = new StreamReader(fsAlumnos))
            {
                using (StreamReader srNotas = new StreamReader(fsNotas))
                {
                    using (StreamWriter swaux = new StreamWriter(aux))
                    {
                        lineaAlumnos = srAlumnos.ReadLine();
                        lineaNotas = srNotas.ReadLine();
                        int cantnotas = 0; float notafinal = 0;

                        while (lineaAlumnos != null && lineaNotas != null)
                        {
                            AlumnoActual = new Alumnos(lineaAlumnos);
                            NotaActual = new Notas(lineaNotas);

                            if (AlumnoActual.DNI == NotaActual.DNI)
                            {

                                notafinal += NotaActual.Nota;
                                cantnotas++;
                                lineaNotas = srNotas.ReadLine();

                            }
                            else
                            {
                                AlumnoActual.Promedio = notafinal / cantnotas;
                                swaux.WriteLine(Alumnos.GenerarRegistro(AlumnoActual));
                                lineaAlumnos = srAlumnos.ReadLine();
                                cantnotas = 0; notafinal = 0;
                            }
                        }

                        AlumnoActual.Promedio = notafinal / cantnotas;
                        swaux.WriteLine(Alumnos.GenerarRegistro(AlumnoActual));
                    }
                }
            }

            fsAlumnos.Close(); fsNotas.Close(); aux.Close();

            File.Delete("alumnos.txt");
            File.Move("alumnosaux.txt", "alumnos.txt");

            LlenarDataGridAlumnos();
        }
    }
}
