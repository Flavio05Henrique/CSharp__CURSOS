namespace ScreenSound.Modelos;

internal class Menu
{
    public void ExibirTituloDaOpecao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = "".PadLeft(quantidadeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }

    protected bool SeBandaNaoExiste(string nome)
    {
        Console.WriteLine($"Banda *{nome}* não registra ou incorretamente digitada");
        Console.WriteLine("Digite qualquer letra para voltar ao inicio ou R para tentar de novo");
        string op = Console.ReadLine()!;
        if (op == "r" || op == "R")
        {
            return true;
        }
        return false;
    }
}
