using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Universidad universidad = new Universidad();
           
            Alumno alumno1 = new Alumno("María", 18, Alumno.Carreras.Ingenieria_de_Sistemas, "2023-0910U");
            Alumno alumno2 = new Alumno("José", 20, Alumno.Carreras.Telecomunicaciones, "2021-0916U");
            alumno1.Calificaciones.Add(80);
            alumno1.Calificaciones.Add(89);
            alumno2.Calificaciones.Add(90);
            alumno2.Calificaciones.Add(70);

            universidad.AgregarAlumno(alumno1);
            universidad.AgregarAlumno(alumno2);

            List<Alumno> alumnosUni = universidad.ObtenerListaAlumnos();
            
            foreach(Alumno alumno in alumnosUni)
            {
                Console.WriteLine($"Nombre:{alumno.Nombre}");
                Console.WriteLine($"Edad: { alumno.Edad}");
                Console.WriteLine($"Número de carné: {alumno.carne}");
                Console.WriteLine($"Calificaciones: {alumno.CalcularPromedioCalificaciones()}");
                Console.WriteLine($"Estado de aprobación: {alumno.EstadoAprobacion() }");


            }
         }
    }
}
