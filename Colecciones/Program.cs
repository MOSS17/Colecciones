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
            //Declaración e inicialización de lista de alumnos
            List<Alumno> Alumnos = new List<Alumno>();

            //Declaración y asignación de valores de alumno1
            Alumno alumno1 = new Alumno();
            alumno1.Nombre = "Juan Pablo";
            alumno1.Materias.Add(new Materia("Historia", "HT965474"));
            alumno1.Materias.Add(new Materia("Matematicas", "MAT946381"));
            alumno1.Materias.Add(new Materia("Programacion", "PRG976548"));
            Alumnos.Add(alumno1);

            Alumno alumno2 = new Alumno();
            alumno2.Nombre = "Carlos Sánchez";
            alumno2.Materias.Add(new Materia("Civismo", "CV646572"));
            alumno2.Materias.Add(new Materia("Ciencias Naturales", "CNT546681"));
            alumno2.Materias.Add(new Materia("Geografia", "GEO635468"));
            Alumnos.Add(alumno2);

            Alumno alumno3 = new Alumno();
            alumno3.Nombre = "Pedro Ramírez";
            alumno3.Materias.Add(new Materia("Biologia", "BLG654874"));
            alumno3.Materias.Add(new Materia("Etica", "ETC641381"));
            alumno3.Materias.Add(new Materia("Tutorias", "TUT676548"));
            Alumnos.Add(alumno3);

            Alumno alumno4 = new Alumno();
            alumno4.Nombre = "Raúl Campos";
            alumno4.Materias.Add(new Materia("Español", "ESP343728"));
            alumno4.Materias.Add(new Materia("Ingles", "ING346182"));
            alumno4.Materias.Add(new Materia("Educacion Fisica", "EDF375468"));
            Alumnos.Add(alumno4);
            
            foreach (Alumno elemento in Alumnos)
            {
                Console.WriteLine("Nombre: " + elemento.Nombre);
                foreach (Materia materia in elemento.Materias) {
                    Console.WriteLine("Materia: " + materia.Nombre);
                //alumno.Materias[i].Nombre;
                }
            }

            Console.ReadLine();
        }
    }
}
