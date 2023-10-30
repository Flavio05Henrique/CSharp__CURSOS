namespace ScreenSound.Modelos;

internal class MenuListarBandas : Menu
{
    public void OpenMenu(Dictionary<string, Banda> listaDeBandas)
    {
        Console.Clear();
        ExibirTituloDaOpecao("Bandas!");

        foreach (string banda in listaDeBandas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        }

        Console.WriteLine("Pressione qualquer tecla para voltar.");
        Console.ReadKey();
    }
}
