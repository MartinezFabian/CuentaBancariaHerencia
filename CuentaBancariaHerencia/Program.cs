using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaBancariaHerencia
{
    internal class Program
    {
        static void Main()
        {
            CuentaCorriente cuentaCorriente1 = new CuentaCorriente(10000);

            CuentaAhorro cuentaAhorro1 = new CuentaAhorro(10000);

            Random random = new Random();

            for (int i = 0; i < 25; i++)
            {
                int numeroRandom = random.Next(10, 10000);

                cuentaAhorro1.Depositar(numeroRandom);
            }

            for (int i = 0; i < 25; i++)
            {
                int numeroRandom = random.Next(10, 10000);

                cuentaAhorro1.Extraer(numeroRandom);
            }

            for (int i = 0; i < 25; i++)
            {
                int numeroRandom = random.Next(10, 10000);

                cuentaCorriente1.Depositar(numeroRandom);
            }

            for (int i = 0; i < 25; i++)
            {
                int numeroRandom = random.Next(10, 10000);

                cuentaCorriente1.Extraer(numeroRandom);
            }

        }
    }
}
