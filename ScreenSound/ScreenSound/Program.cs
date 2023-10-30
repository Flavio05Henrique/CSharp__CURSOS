using ScreenSound.Modelos;

//Musica musica = new Musica("Forever", "Kiss", 4.20);
//musica.Disponivel = true;

//Console.WriteLine(musica.DescricaoResumida);

//musica.ExibirFichaTecnica();

Musica musica = new Musica("Seven Seas of Rhye", "Queen", 2.49);

Musica musica2 = new Musica("Procession", "Queen", 1.13);

Musica musica3 = new Musica("The March of the Black Quee", "Queen", 6.04);

Musica musica4 = new Musica("White Queen (As It Began)", "Queen", 4.36);

Album albumDoQueen = new Album("Queen II", musica);
albumDoQueen.AdicionarMusica(musica2);
albumDoQueen.AdicionarMusica(musica3);
albumDoQueen.AdicionarMusica(musica4);

//albumDoQueen.ExibirMusicasDoAlbum();

// Screen Sound

string mensagemDeBoasVindas = "Boas vindas";
string separa = @"
    
    ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
    ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
    ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
";

Banda queen = new Banda("Queen");
Banda metallica = new Banda("Metallica");
Banda kiss = new Banda("Kiss");

//List<string> listaDeBandas = new List<string>() { "Metallica", "Kiss", "Iron Maiden" };
Dictionary<string, Banda> listaDeBandas = new();
listaDeBandas.Add(queen.Nome, queen);
listaDeBandas.Add(metallica.Nome, metallica);
listaDeBandas.Add(kiss.Nome, kiss);

void ExibirLogo()
{
    Console.WriteLine(separa);
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    Console.Clear();
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite sua opeção: ");
    string opecaoEscolhida = Console.ReadLine()!;
    string opecaoEscolhidaConverte = opecaoEscolhida;

    switch (opecaoEscolhidaConverte)
    {
        case "1":
            MenuRegistraBanda menu = new();
            menu.OpenMenu(listaDeBandas);
            ExibirOpcoesDoMenu();
            break;
        case "2":
            MenuListarBandas menu2 = new();
            menu2.OpenMenu(listaDeBandas);
            ExibirOpcoesDoMenu();
            break;
        case "3":
            MenuAvaliarBanda menu3 = new();
            menu3.OpenMenu(listaDeBandas);
            ExibirOpcoesDoMenu();
            break;
        case "4":
            MenuExibeMediaDeUmaBanda menu4 = new();
            menu4.OpenMenu(listaDeBandas);
            ExibirOpcoesDoMenu();
            break;
        default:
           ;
            break;
    }
}

ExibirOpcoesDoMenu();
