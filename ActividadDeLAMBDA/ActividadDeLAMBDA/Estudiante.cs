using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadDeLAMBDA
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public double Nota { get; set; }

        public Estudiante(string nombre, string apellido, int edad, double nota)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Nota = nota;

        }

    }
}
