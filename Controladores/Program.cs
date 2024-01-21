using Ejercicio3Repaso1.Servicios;

namespace Ejercicio3Repaso1
{
    class program
    {
        public static void Main(String[] args)
        {
            OperacionInterfaz op = new OperacionImplementacion();
            string afirmacion;
            do
            {
                Console.WriteLine("Las furgonetas solo pueden tener un maximo de 4000kg en sacos.");
                op.calcularSacos();
                afirmacion = op.afirmacion();

            } while (afirmacion=="s");

        }
    }
}
