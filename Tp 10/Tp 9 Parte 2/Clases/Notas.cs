using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_9_Parte_2
{
    internal class Notas
    {
        private decimal _dni;
        private float _nota;
        private DateTime _fecha;

        public decimal DNI { get { return _dni; } set { _dni = value; } }
        public float Nota { get { return _nota; } set { _nota = value; } }
        public DateTime Fecha { get { return _fecha; } set { _fecha = value; } }

        public Notas(string linea)
        {
            string[] notas = linea.Split('-');

            this.DNI = decimal.Parse(notas[0]);
            this.Nota = float.Parse(notas[1]);
            this.Fecha = DateTime.Parse(notas[2]);

        }

        public Notas(decimal dni, decimal nota, DateTime fecha)
        {
            this.DNI = dni;
            this.Nota = (float)nota;
            this.Fecha = fecha;
        }

        public static string GenerarRegistro(Notas Nota)
        {
            return $"{Nota.DNI}-{Nota.Nota}-{Nota.Fecha}";
        }

    }
}
