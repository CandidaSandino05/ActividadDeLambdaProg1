using ActividadDeLAMBDA;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("----Estudiantes en ejemplo Lambda----");

        List<Estudiante> Listaestudiantes = new List<Estudiante>()
        {
             new Estudiante("Mariano", "Cordero", 16, 45),
             new Estudiante("Fernanda", "Jarquin", 18, 65),
             new Estudiante("Candida C.", "Sandino", 19, 95),
             new Estudiante("Luz", "Montes", 20, 75),
             new Estudiante("Edgard", "Torrez", 17, 90),
             new Estudiante("Carlos", "Montenegro", 20, 53),
             new Estudiante("Cristhopher", "Aleman", 16, 79),
        };

        //Estudiantes mayores de 18 años

        var estudiantesMayoresa18 = Listaestudiantes.Where(e => e.Edad > 18).ToList();

        //Estudiantes en orden ascendente 
        var estudiantesenorden = Listaestudiantes.OrderBy(e => e.Nombre).ToList();

        //La nota mas alta 
        var estudianteMejorNota = Listaestudiantes.OrderByDescending(e => e.Nota).First();

        //Promedio de notas 
        double PromedioDeNotas = Listaestudiantes.Average(e => e.Nota);

        Console.WriteLine("Estudiantes mayores a 18 años: ");
        foreach (var Estudiante in estudiantesMayoresa18)
        {
            Console.WriteLine($"Nombre:{Estudiante.Nombre}, Apellido:{Estudiante.Apellido}, Edad:{Estudiante.Edad}, Nota:{Estudiante.Nota}");
        }


        Console.WriteLine("\nEstudiantes ordenados en forma ascendente: ");
        foreach (var Estudiante in estudiantesenorden)
        {
            Console.WriteLine($"Nombre: {Estudiante.Nombre}, Apellido:{Estudiante.Apellido}, Edad:{Estudiante.Edad}, Nota:{Estudiante.Nota}");
        }


        Console.WriteLine("\nEstudiante con la nota más alta: ");
        {
            Console.WriteLine($"Nombre:{estudianteMejorNota.Nombre}, Nota:{estudianteMejorNota.Nota}");
        }

        Console.WriteLine($"\nPromedio de nota de los estudiantes: ");
        {
            Console.WriteLine("Promedio de Notas: " + PromedioDeNotas);
        }

        Console.WriteLine("****************************************************************************************************" +
                          "*****************************************************************************************************");

        //Ejemplo simple de funcion lambda
        Console.WriteLine("LAMBDA programacion1");

        Func<int, int, int> suma = (a, b) => a + b;
        Console.WriteLine(suma(3, 4));

        //Ejemplo de lambda con parentesis opcionales 
        Func<double, double> prod = x => x * x;
        Console.WriteLine(prod(10));

        //Ejemplo de lambda especificando de manera explicita 
        Func<int, string, bool> isTooLong = (int x, string s) => s.Length > x;

        Console.WriteLine(isTooLong(10, "Programacion 1"));


        //Ejemplo de Lambda con multiples Lineas 

        Action<int> mayoredad = n =>
        {
            Boolean ME = (n > 18) ? true : false;
            Console.WriteLine($"Es mayor de edad : {ME}");
        };

        mayoredad(20);

        //Expresion con parametro sin uso 

        Action<string> saludar = _ => Console.WriteLine("Hola!!");
        saludar("Ignorado"); //Salida: Hola!!

    }


}

