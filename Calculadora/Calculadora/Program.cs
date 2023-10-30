using Calculadora;
using System.Diagnostics;

Calculadora.Calculadora calculadora = new();
EscreveNaTela tela = new();

void principal()
{
    string operacao = tela.Escreve();
    Console.Clear();
    string resultado = calculadora.Calcular(operacao);
    Console.WriteLine(resultado);
}

try
{
    principal();
}
catch (Exception e)
{
    Console.Clear();
    Console.WriteLine(e.Message);
    Console.WriteLine(e);
    Console.WriteLine("Deseja tentar de novo? s/n");
    string valor = Console.ReadLine();
    if (valor == "s")
    {
        Console.Clear();
        principal();
    }
}


//for (int i = 0; i < 1000; i++)
//{
//   string result = calculadora.Calcular("15+5*5/2");
//   if(result != "27,5")
//    {
//        Console.WriteLine($"resultado falho: {result}");
//        i = 1000;
//    }
//}
//Console.WriteLine("Encerado");
