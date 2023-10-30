using System.Text.Json;

namespace ScreenSound__ConsumindoApis.Modelos;

internal class MusicasFavoritas
{
    public string? Nome { get; }
    public List<Musica> ListaDeMusicasFavoritas { get;}

    public MusicasFavoritas(string nome, Musica musica)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new();
        AdicionarMusicaFavorita(musica);
    }

    public void AdicionarMusicaFavorita(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são as musicas favoritas do(a) {Nome}: ");
        foreach (var musica in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($"--> {musica.Nome} de {musica.Artista}");
        }
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new { 
            nome = Nome,
            musicas = ListaDeMusicasFavoritas
        });
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"Aquivo json criado com sucesso. {Path.GetFullPath(nomeDoArquivo)}");
    }
}
