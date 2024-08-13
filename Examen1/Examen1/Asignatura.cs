using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    public class Asignatura : Alumno, IAsignatura
    {
        public int N1;

        public int N2;

        public int N3;

        public double notaFinal;

        public string NombreAsignatura { get; set; }

        public string Horario;

        public string NombreDocente { get; set; }

        public Asignatura(int n1, int n2, int n3, string nombreAsignatura, string horario, string nombreDocente, string nombreAlumno, string numeroCuenta, string email) : base(nombreAlumno, numeroCuenta, email)
        {
            N1 = n1;
            N2 = n2;
            N3 = n3;
            NombreAsignatura = nombreAsignatura;
            Horario = horario;
            NombreDocente = nombreDocente;
        }

        public double CalcularNotaFinal()
        {
            return notaFinal = N1 + N2 + N3;
        }

        public double CalcularNotaFinal(int n1, int n2, int n3)
        {
            return notaFinal = n1 + n2 + n3;
        }

        public string MensajeNotaFinal(double notaFinal)
        {
            if (notaFinal >= 0 && notaFinal < 60)
                return "Reprobado";
            else if (notaFinal >= 60 && notaFinal < 80)
                return "Bueno";
            else if (notaFinal >= 80 && notaFinal < 90)
                return "Muy Bueno";
            else
                return "Sobresaliente";

        }

        public void Imprimir()
        {
            Console.WriteLine($"Alunmo: {NombreAlumno}");
            Console.WriteLine($"Número de cuenta: {NumeroCuenta}");
            Console.WriteLine($"Correo electrónico: {Email}");
            Console.WriteLine($"Nombre de la clase: {NombreAsignatura}");
            Console.WriteLine($"Horario: {Horario}");
            Console.WriteLine($"Nombre del docente: {NombreDocente}");
            Console.WriteLine($"Nota Final: {CalcularNotaFinal()}% - {MensajeNotaFinal(notaFinal)}");
            Console.WriteLine($"Nota Final: {CalcularNotaFinal()}% - {MensajeNotaFinal(notaFinal)}");
        }
    }
}
