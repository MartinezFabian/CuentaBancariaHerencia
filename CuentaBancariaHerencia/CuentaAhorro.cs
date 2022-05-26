using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaBancariaHerencia
{
    internal class CuentaAhorro : CuentaBancaria
    {
        public CuentaAhorro(double saldo) : base(saldo)
        { 
        
        }

        public override void Extraer(double extraccion)
        {
            if ((Saldo - extraccion) >= 0 && Saldo >= 0)
            {
                Saldo -= extraccion;
                Console.WriteLine("Extracción realizada. Saldo actual: " + Saldo);
            }
            else
            {
                Console.WriteLine("Saldo insuficiente. No puede extraer dinero.");
            }
        }
    }
}
