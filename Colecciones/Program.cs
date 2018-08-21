using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno = new Alumno();
            alumno.Nombre = "Juan Perez";
            alumno.Matricula = "195636";
            

            Materia matematicas = new Materia();
            matematicas.Nombre = "Matematicas";
            matematicas.Identificador = "MT12358";

            alumno.Materias.Add(new Materia());
            alumno.Materias.Add(matematicas);

            alumno.Materias[0].Nombre = "Historia";
            alumno.Materias[1].Nombre = "Matematicas";
            alumno.Materias[0].Identificador = "HT96465";

            alumno.Materias.Add(new Materia());
            alumno.Materias[2].Nombre = "Español";
            alumno.Materias[2].Identificador = "ES852";

            alumno.Materias.RemoveAt(1);
            alumno.Materias.RemoveAt(1);
            alumno.Materias.Clear();

            Console.WriteLine("Alumno: " + alumno.Nombre);
            Console.WriteLine("Numero de materias: " + alumno.Materias.Count);

            foreach (Materia materia in alumno.Materias)
            {
                Console.WriteLine("Materia: " + materia.Nombre);
                //alumno.Materias[i].Nombre;
            }


            Console.ReadLine();
        }
    }
}
