
using System.Text.Json.Serialization;

namespace ScreenSound__ConsumindoApis.Modelos;

internal class Musica
{
    [JsonPropertyName("song")]
    public string? Nome { get; set; }
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    [JsonPropertyName("duration_ms")]
    public int? Duracao {  get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    public void DetalhaDadosMusica()
    {
       Console.WriteLine($"Artista: ${Artista} \r\nlMúsica: {Nome} \r\nDuração: {Duracao/1000}s \r\nGênero: {Genero}");
    }

}
