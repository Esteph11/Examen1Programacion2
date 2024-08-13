
namespace Examen1
{
    public class Asignatura : Alumno, IAsignatura
    {
        public Asignatura(int n1, int n2, int n3, string nombreAsignatura, string horario, string nombreDocente, string nombreAlumno, string numeroCuenta, string email) : base(nombreAlumno, numeroCuenta, email)
        {
            this.N1 = n1;
            this.N2 = n2;
            this.N3 = n3;
            this.NombreAsignatura = nombreAsignatura;
            this.Horario = horario;
            this.NombreDocente = nombreDocente;
        }

        public int N1 { get; set; }

        public int N2 { get; set; }

        public int N3 { get; set; }

        public double notaFinal { get; set; }

        public string NombreAsignatura { get; set; }

        public string Horario { get; set; }

        public string NombreDocente { get; set; }

        public double CalcularNotaFinal()
        {
            return N1 + N2 + N3 / 3;
        }

        public double CalcularNotaFinal(int n1, int n2, int n3)
        {
            return (n1 + n2 + n3) / 3;
        }

        public string MensajeNotaFinal(double notaFinal)
        {
            if (notaFinal >= 0 && notaFinal< 60)  
                return "Reprobado";  
            else if (notaFinal >= 60 && notaFinal< 80)  
                return "Bueno";  
            else if (notaFinal >= 80 && notaFinal< 90)  
                return "Muy Bueno";  
            else  
                return "Sobresaliente";  

        }

        public void Imprimir()
        {
            Console.WriteLine($"Alunmo: {NombreAlumno}");
            Console.WriteLine($"Asignatura: {NombreAsignatura}");
            Console.WriteLine($"La Nota Final es: {CalcularNotaFinal()}");
            Console.WriteLine($"Rango de nota: {notaFinal}");
        }
    }
}
