
namespace Examen1
{
    public interface IAsignatura
    {
        public double CalcularNotaFinal();

        public double CalcularNotaFinal(int n1, int n2, int n3);
        
        public string MensajeNotaFinal(double notaFinal);

    }
}
