using Examen1;
using static System.Runtime.InteropServices.JavaScript.JSType;

//List<Asignatura> asignaturaList = new List<Asignatura>();
int n1, n2, n3;
FileStream file = null;
try
{
    Asignatura asignatura = new Asignatura();

    Console.WriteLine("Ingrese el nombre del alumno:");
    string nombreAlumno = Console.ReadLine();
    Console.WriteLine("Ingrese el número de cuenta del alumno:");
    string numeroCuenta = Console.ReadLine();
    Console.WriteLine("Ingrese el correo electrónico del alumno:");
    string email = Console.ReadLine();
    Console.WriteLine("Ingrese el nombre de la asignatura:");
    string nombreAsignatura = Console.ReadLine();
    Console.WriteLine("Ingrese el horario de la asignatura:");
    string horario = Console.ReadLine();
    Console.WriteLine("Ingrese el nombre del docente de la asignatura:");
    string nombreDocente = Console.ReadLine();
    Console.WriteLine();

        Console.WriteLine("Ingrese la nota del primer parcial (Valor 30%):");
        while (!int.TryParse(Console.ReadLine(), out n1) || n1 < 0 || n1 > 30)
        {
            Console.WriteLine("Error, la nota ingresada tiene que ser entre 0 y 30: ");
        }
        Console.WriteLine("Ingrese la nota del segundo parcial (Valor 30%):");
        while (!int.TryParse(Console.ReadLine(), out n2) || n2 < 0 || n2 > 30)
        {
            Console.WriteLine("Error, la nota ingresada tiene que ser entre 0 y 30: ");
        }
        Console.WriteLine("Ingrese la nota del tercer parcial (Valor 40%):");
        while (!int.TryParse(Console.ReadLine(), out n3) || n3 < 0 || n3 > 40)
        {
            Console.WriteLine("Error, la nota ingresada tiene que ser entre 0 y 40: ");
        }

  
        Console.WriteLine("********************************");
        asignatura.Imprimir();
    Console.WriteLine();
    Console.ReadKey();
}
    catch (FormatException e)
    {
        Console.WriteLine(e.ToString());
    }
    catch (Exception e)
    {
        Console.WriteLine(e.ToString());
    }
    finally
    {
        file?.Close();
        Console.WriteLine("Error...");
    }


