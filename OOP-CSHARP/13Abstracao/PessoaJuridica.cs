using System;
class PessoaJuridica : Padrao
{
    // Método obrigatório
    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine($"Taxa de emprestimo para Pessoa Juridica R${valor*0.2}");
    }
}