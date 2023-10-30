namespace ScreenSound.Modelos;

internal class MenuAvaliarBanda : Menu
{
    public  void OpenMenu(Dictionary<string, Banda> listaDeBandas)
    {
        Console.Clear();
        ExibirTituloDaOpecao("Avaliar Banda!");
        Console.Write("Digite nome da banda: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (!listaDeBandas.ContainsKey(nomeDaBanda))
        {
            bool tentarDeNovo = SeBandaNaoExiste(nomeDaBanda);
            if (tentarDeNovo == true) OpenMenu(listaDeBandas);
            return;
        }
        Console.Write($"De sua nota de 0 a 10 a banda {nomeDaBanda}: ");
        Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
        listaDeBandas[nomeDaBanda].AdicionarNota(nota);
        Console.WriteLine("Nota registra! Agradecemos a avaliação");
        Thread.Sleep(2500);
        Console.Clear();
    }
}
