using System;
using System.Collections.Generic;
using System.Text;

//Subclasse Conta Poupança
namespace POO_TarefaUpDownCasting.Entities
{
    class ContaPoupanca
    {
        private double taxaJuros;

        public ContaPoupanca() : base()
        {
            base();
        }
        public ContaPoupanca(int numero,string titular, double saldo, double taxaJuros): 
            base (numero,titular,saldo)
        {
            base(numero, titular, saldo);
            taxaJuros = taxaJuros;
        }

        public void atualizacaoSaldo()
        {
            saldo +=saldo * taxaJuros; 
        }

        public sealed override void Saque(double saldoTotal)
        {
            base.Saque(saldoTotal);
            Saldo -= 2.0;
        }

    }
}
