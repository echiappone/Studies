using System;

namespace _13Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();
            pf.taxaEmprestimo(1000);
            pf.calculoPoupanca(3000,0.05);
            Console.WriteLine("-------------");

            PessoaJuridica pj = new PessoaJuridica();
            pj.taxaEmprestimo(1000);
        }
    }
}