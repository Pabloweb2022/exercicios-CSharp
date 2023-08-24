using System;
using System.Globalization;

namespace Course
{
    internal class ContaBancaria
    {
        public int Conta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int conta, string titular)
        {
            Conta = conta;
            Titular = titular;
        }
        public ContaBancaria(int conta,string titular,double deposito):this(conta,titular) {
            AdicionaSaldo(deposito);
        }
        public void AdicionaSaldo(double deposito) {
            Saldo += deposito;
        }

        public void RemoveSaldo(double saldo)
        {
            Saldo -= saldo + 5.00;    
        }

        public override string ToString()
        {
            return "Conta " + Conta + ", " + "Titular: " +Titular +", Saldo: $"+ Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
