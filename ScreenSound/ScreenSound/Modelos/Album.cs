namespace ScreenSound.Modelos;
internal class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; }
    public double DuracaoTotal => musicas.Sum(musica => musica.Duracao);

    public Album(string nome, Musica musica)
    {
        Nome = nome;
        musicas.Add(musica);
    }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Albume {Nome}");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Nome: {musica.Nome} Duração: {musica.Duracao}");
        }
        Console.WriteLine($"Duração total do album: {DuracaoTotal}");
    }
}