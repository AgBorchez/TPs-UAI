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
    public partial class ManejoNotas : Form
    {
        internal List<Notas> NotasEnPantalla = new List<Notas>();

        private void LlenarDataGrid(List<Notas> lista)
        {
            dataGridContenido.DataSource = null;
            dataGridContenido.DataSource = lista;
            dataGridContenido.Columns[0].HeaderText = "DNI";
            dataGridContenido.Columns[1].HeaderText = "Nota";
            dataGridContenido.Columns[2].HeaderText = "Fecha";
        }
        private void RefrescoDataGrid()
        {
            NotasEnPantalla.Clear();
            FileStream fs = new FileStream("notas.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            using (StreamReader sr = new StreamReader(fs))
            {
                string linea = sr.ReadLine();

                while (linea != null)
                {
                    NotasEnPantalla.Add(new Notas(linea));
                    linea = sr.ReadLine();
                }
            }
            fs.Close();
            LlenarDataGrid(NotasEnPantalla);
        }

        private void Escritura()
        {
            FileStream fs = new FileStream("notas.txt", FileMode.OpenOrCreate, FileAccess.Write);

            using (StreamWriter sw = new StreamWriter(fs))
            {
                foreach(Notas nota in NotasEnPantalla)
                {
                    sw.WriteLine(Notas.GenerarRegistro(nota));
                }
            }

            fs.Close();
        }

        public ManejoNotas()
        {
            InitializeComponent();
            RefrescoDataGrid();
        }

        private void dataGridContenido_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dataGridContenido.SelectedRows.Count > 0)
            {
                Notas notaSeleccionada = (Notas)dataGridContenido.SelectedRows[0].DataBoundItem;

                ValorDNI.Enabled = false;
                ValorDNI.Value = notaSeleccionada.DNI;
                ValorNota.Value = (decimal)notaSeleccionada.Nota;
                dateTimePickerFechaNota.Value = notaSeleccionada.Fecha;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("notas.txt", FileMode.Append, FileAccess.Write);

            using (StreamWriter sw = new StreamWriter(fs))
            {
                Notas NotaNueva = new Notas(ValorDNI.Value, ValorNota.Value, dateTimePickerFechaNota.Value);
                sw.WriteLine(Notas.GenerarRegistro(NotaNueva));
            }

            fs.Close();

            RefrescoDataGrid();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridContenido.SelectedRows.Count > 0)
            {
                Notas NotaSeleccionada = (Notas)dataGridContenido.SelectedRows[0].DataBoundItem;
                Notas NotaNueva = new Notas(ValorDNI.Value, ValorNota.Value, dateTimePickerFechaNota.Value);

                FileStream fs = new FileStream("notas.txt", FileMode.OpenOrCreate, FileAccess.Read);
                FileStream aux = new FileStream("notasaux.txt", FileMode.OpenOrCreate, FileAccess.Write);

                using (StreamReader sr = new StreamReader(fs))
                {
                    using (StreamWriter sw = new StreamWriter(aux))
                    {
                        string linea = sr.ReadLine();
                        while (linea != null)
                        {
                            Alumnos LineaActual = new Alumnos(linea);
                            if (LineaActual.DNI != NotaSeleccionada.DNI)
                            {
                                sw.WriteLine(linea);
                            }
                            else
                            {
                                sw.WriteLine(Notas.GenerarRegistro(NotaNueva));
                            }
                            linea = sr.ReadLine();
                        }
                    }
                }

                fs.Close();
                aux.Close();

                File.Delete("notas.txt");
                File.Move("notasaux.txt", "notas.txt");

                RefrescoDataGrid();
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridContenido.SelectedRows.Count > 0)
            {
                Notas NotaSeleccionada = (Notas)dataGridContenido.SelectedRows[0].DataBoundItem;
                FileStream fs = new FileStream("notas.txt", FileMode.OpenOrCreate, FileAccess.Read);
                FileStream aux = new FileStream("notasaux.txt", FileMode.OpenOrCreate, FileAccess.Write);

                using (StreamReader sr = new StreamReader(fs))
                {
                    using (StreamWriter sw = new StreamWriter(aux))
                    {
                        string linea = sr.ReadLine();
                        while (linea != null)
                        {
                            if (linea != Notas.GenerarRegistro(NotaSeleccionada))
                            {
                                sw.WriteLine(linea);
                            }
                            linea = sr.ReadLine();
                        }
                    }
                }

                fs.Close();
                aux.Close();

                File.Delete("notas.txt");
                File.Move("notasaux.txt", "notas.txt");

                RefrescoDataGrid();
            }
        }

        private void ManejoNotas_Click(object sender, EventArgs e)
        {
            ValorDNI.Enabled = true;
            ValorDNI.Value = 0;
            ValorNota.Value = 0;
        }

        private void BtnOrdenar_Click(object sender, EventArgs e)
        {
            if (radioButtonDNI.Checked)
            {
                NotasEnPantalla = NotasEnPantalla.OrderBy(a => a.DNI).ToList();
                Escritura();
            }
            if (radioButtonNota.Checked)
            {
                NotasEnPantalla = NotasEnPantalla.OrderBy(a => a.Nota).ToList();
                Escritura();
            }
            if (radioButtonFecha.Checked)
            {
                NotasEnPantalla = NotasEnPantalla.OrderBy(a => a.Fecha).ToList();
                Escritura();
            }

            RefrescoDataGrid();
        }
    }
}
