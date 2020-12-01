using System;

/*
 * CLONE DO REPOSITÓRIO DO PROJETO DA AULA DIA 16/11/20 (HERANÇA)
 * MODIFICAÇÕES NO NOVO PROJETO SEGUINDO O EXEMPLO DA AULA COM TEMA DE CLASSES ABSTRATAS
 * Tema Conta Bancária
 */
namespace POO_TarefaUpDownCasting.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta acc = new Conta(1001, "Goku", 0.0);
            ContaJuridica bacc = new ContaJuridica(1002, "Goten", 0.0, 500.0);

            //Upcasting
            Conta acc1 = bacc;
            Conta acc2 = new ContaJuridica(1003, "trunks", 0.0, 200.00);
            Conta acc3 = new ContaJuridica(1004, "Vegeta", 0.0, 0.01);

            //Downcasting
            ContaJuridica acc4 = (ContaJuridica)acc2;
            acc4.Emprestimo(100.0);

            if(acc3 is ContaJuridica)
            {
                //ContaPoupanca acc5=(ContaPoupanca)acc3
                ContaJuridica acc5 = (ContaJuridica)acc3;
                acc5.Emprestimo(200.0);
                Console.WriteLine("Empréstimo!");
            }

            if(acc3 is ContaPoupanca)
            {
                ContaPoupanca acc5 = (ContaPoupanca) acc3;
                //ContaJuridica acc5 = acc3 as ContaJuridica;
                acc5.atualizacaoSaldo();
                Console.WriteLine("Atualizado!");
            }

        }
    }
}
