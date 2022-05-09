using System;

class Gerente : Imposto
{
    // Método
    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine($"Desconto gerente do vale alimentação{salario*0.15}");
    }
}