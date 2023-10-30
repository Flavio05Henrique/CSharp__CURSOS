using System.Windows;

namespace ScreenSound.Modelos;
internal class Banda : IAvaliavel
{
    private List<Album> albuns = new List<Album>();
    public List<Avaliacao> notas = new List<Avaliacao>(); 
    public string Nome { get; }
    public double NotaMedia {  
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(n => n.Nota);
        } 
    }
    public List<Album> Albums => albuns;

    public Banda(string nome)
    {
        Nome = nome;
    }   

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome}({album.DuracaoTotal})");
        }
    }
}