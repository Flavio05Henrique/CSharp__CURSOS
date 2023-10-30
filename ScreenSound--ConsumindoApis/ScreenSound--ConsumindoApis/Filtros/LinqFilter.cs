using ScreenSound__ConsumindoApis.Modelos;

namespace ScreenSound__ConsumindoApis.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGeneros(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach(var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"-> {genero}");
        }
    }

    public static void FiltrarArtistasPorGenero(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero))
            .Select(musica => musica.Artista).Distinct().OrderBy(musica => musica).ToList();
        Console.WriteLine($"Atistas filtrados por gênero musical >>> {genero}");
        foreach(var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"--> {artista}");
        }
    }

    public static void FiltrarMusicasPorArtista(List<Musica> musicas, string artista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(artista)).ToList();
        Console.WriteLine(artista);
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"{musica.Nome}");
        }
    }
}
