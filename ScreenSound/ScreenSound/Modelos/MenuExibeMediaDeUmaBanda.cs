namespace ScreenSound.Modelos;

internal class MenuExibeMediaDeUmaBanda : Menu
{
    public void OpenMenu(Dictionary<string, Banda> listaDeBandas)
    {
        Console.Clear();
        ExibirTituloDaOpecao("Media de uma banda!");
        Console.Write("Digite o nome da banda que deseja saber a media: ");
        string nome = Console.ReadLine()!;
        if (!listaDeBandas.ContainsKey(nome))
        {
            bool tentarDeNovo = SeBandaNaoExiste(nome);
            if(tentarDeNovo == true) OpenMenu(listaDeBandas);
            return;
        }
        int media = (int)listaDeBandas[nome].NotaMedia;
        Console.WriteLine($"A media é {media}");
        Console.WriteLine("Pressione qualquer tecla para voltar ao inicio");
        Console.ReadKey();
    }
}
