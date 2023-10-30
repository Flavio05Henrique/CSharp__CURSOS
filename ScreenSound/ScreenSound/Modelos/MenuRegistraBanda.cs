namespace ScreenSound.Modelos;

internal class MenuRegistraBanda : Menu
{
    public void OpenMenu(Dictionary<string, Banda> listaDeBandas)
    {
        Console.Clear();
        ExibirTituloDaOpecao("Registra banda");
        Console.Write("Digite o nome da banda que deseja registrar ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda novaBanda = new Banda(nomeDaBanda);
        listaDeBandas.Add(nomeDaBanda, novaBanda);
        Console.WriteLine($"A banda foi registrada com sucesso {nomeDaBanda}");
    }
}
