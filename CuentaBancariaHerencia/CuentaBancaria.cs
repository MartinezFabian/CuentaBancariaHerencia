using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaBancariaHerencia
{
    abstract class CuentaBancaria
    {
        private double saldo;

        public double Saldo { get => saldo; set => saldo = value; }

        public CuentaBancaria(double saldoInicial)
        {
            this.Saldo = saldoInicial;
        }

        public void Depositar(double deposito)
        {
            Saldo += deposito;
            Console.WriteLine("Deposito exitoso. Saldo actual " + Saldo);
        }

        public abstract void Extraer(double extraccion);
      
    }
}
