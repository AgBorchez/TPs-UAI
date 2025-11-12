using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_9_Parte_2
{
    internal class Alumnos
    {
        private decimal _dni;
        private string _nombre;
        private string _apellido;
        private float _promedio;

        public decimal DNI { get { return _dni; } set { _dni = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Apellido { get { return _apellido; } set { _apellido = value; } }

        public float Promedio { get { return _promedio; } set { _promedio = value; } }


        public Alumnos(string linea)
        {
            string[] registro = linea.Split('-');

            this.DNI = decimal.Parse(registro[0]);
            this.Nombre = registro[1];
            this.Apellido = registro[2];
            this.Promedio = float.Parse(registro[3]);
        }

        public Alumnos(decimal Dni, string Nombre, string Apellido) 
        {
            this.DNI = Dni;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
        }

        public static string GenerarRegistro(Alumnos Alumno)
        {
            return $"{Alumno.DNI}-{Alumno.Nombre}-{Alumno.Apellido}-{Alumno.Promedio}";
        }
    }
}
