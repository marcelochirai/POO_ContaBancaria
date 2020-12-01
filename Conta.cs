using System;
using System.Collections.Generic;
using System.Text;


//Material do dia 16-11-2020
namespace POO_TarefaUpDownCasting.Entities
{
    
    //Superclass Conta
    class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; protected set; }

        public Conta()
        {
            void Conta(int numero, string titular, double saldo)
            {
                Numero = numero;
                Titular = titular;
                Saldo = saldo;
            }
        }

            public virtual void Saque(double saldoTotal)
            {
                Saldo -= saldoTotal;
            }

            void Deposito(double saldoTotal)
            {
                Saldo += saldoTotal;
            }


    }
}

