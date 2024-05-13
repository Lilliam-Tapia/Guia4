using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia4
{
    public partial class Alumno
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string carne { get; set; }
        public Carreras carrera { get; set; }
        public List<double> Calificaciones { get; set; }

        public Alumno(string nombre, int edad, Carreras carrera, string carne)
        {
            Nombre = nombre;
            Edad = edad;
            this.carrera = carrera;
            this.carne = carne;
            this.Calificaciones = new List<double>();
        }
        public double CalcularPromedioCalificaciones()
        {
            if (Calificaciones.Count == 0)
            {
                return 0;
            }
            double sumaCalificaciones = 0;
            foreach (var calificacion in Calificaciones)
            {
                sumaCalificaciones += calificacion;
            }
            return sumaCalificaciones / Calificaciones.Count;
        }
        public string EstadoAprobacion()
        {
            double promedo = CalcularPromedioCalificaciones();
            if (promedo >= 60)
            {
                return "Aprobado";
            }
            else
            {
                return "Reprobado";
            }
        }
        public enum Carreras
        {
            Ingenieria_de_Sistemas,
            Ingenieria_en_computacion,
            Telecomunicaciones,
            Ingeneiria_electronica
        }
    }
}
