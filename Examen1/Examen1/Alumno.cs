
using System.ComponentModel.DataAnnotations;

namespace Examen1
{
    public class Alumno
    {
        public string NombreAlumno { get; set; }

        public string NumeroCuenta { get; set; }

        public string Email { get; set; }

        public Alumno(string nombreAlumno, string numeroCuenta, string email)
        {
            this.NombreAlumno = nombreAlumno;
            this.NumeroCuenta = numeroCuenta;
            this.Email = email;

        }
    }
}
