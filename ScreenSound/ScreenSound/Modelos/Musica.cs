namespace ScreenSound.Modelos;
internal class Musica
{
    public string Nome { get; }
    public string Artista {  get; }
    public double Duracao { get; }
    public bool Disponivel {  get; set; }
    //public string DescricaoResumida
    //{
    //    get
    //    {
    //        return $"A música {Nome} pertence à banda {Artista} ";
    //    }
    //}

    //Segunda forma de declarar um atributo só leitura.
    public string DescricaoResumida => 
        $"A música {Nome} pertence à banda {Artista} ";

    public Musica(string nome, string artista, double duracao)
    {
        Nome = nome;
        Artista = artista;
        Duracao = duracao;
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {this.Nome}");
        Console.WriteLine($"Artista: {this.Artista}");
        Console.WriteLine($"Duração: {this.Duracao}");
        if(Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        } else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }

}       