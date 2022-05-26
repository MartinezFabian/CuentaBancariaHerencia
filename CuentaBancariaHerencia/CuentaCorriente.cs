using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaBancariaHerencia
{
    internal class CuentaCorriente : CuentaBancaria
    {
        private double topeNegativo;

        public double TopeNegativo { get => topeNegativo; set => topeNegativo = value; }

        public CuentaCorriente(double saldo) : base(saldo)
        {
            topeNegativo = -10000;
        }

        public override void Extraer(double extraccion)
        {
            if ((Saldo - extraccion) > 0 && Saldo >= 0)
            {
                Saldo -= extraccion;
                Console.WriteLine("Extracción realizada. Saldo actual: " + Saldo);
            }
            else if ((Saldo - extraccion) >= topeNegativo)
            {
                Saldo -= extraccion;
                Console.WriteLine("Su saldo es negativo. Esta debiendo al banco: " + Saldo * 1.1 + " pesos.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente. No puede extraer dinero.");
            }
        }
    }
}
