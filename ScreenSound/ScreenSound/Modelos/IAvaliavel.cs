namespace ScreenSound.Modelos;

internal interface IAvaliavel
{
    void AdicionarNota(Avaliacao nota);
    double NotaMedia {  get; }
    
}
