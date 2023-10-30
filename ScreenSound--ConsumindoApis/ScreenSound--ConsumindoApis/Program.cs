using ScreenSound__ConsumindoApis.Filtros;
using ScreenSound__ConsumindoApis.Modelos;
using System.Text.Json;

using (HttpClient client = new())
{
    try
    {
        string url = "https://guilhermeonrails.github.io/api-csharp-songs/songs.json";
        string resposta = await client.GetStringAsync(url);
        var musicas =  JsonSerializer.Deserialize<List<Musica>>(resposta);
        //LinqFilter.FiltrarTodosOsGeneros(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGenero(musicas, "pop");
        //LinqFilter.FiltrarMusicasPorArtista(musicas, "U2");

        MusicasFavoritas minhasMusicas = new("Flavio", musicas[254]);
        minhasMusicas.AdicionarMusicaFavorita(musicas[152]);
        minhasMusicas.AdicionarMusicaFavorita(musicas[1520]);
        minhasMusicas.AdicionarMusicaFavorita(musicas[15]);
        minhasMusicas.AdicionarMusicaFavorita(musicas[248]);

        minhasMusicas.ExibirMusicasFavoritas();
        minhasMusicas.GerarArquivoJson();
        Console.ReadLine();

    } catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}