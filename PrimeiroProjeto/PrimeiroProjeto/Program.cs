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

//List<string> listaDeBandas = new List<string>() { "Metallica", "Kiss", "Iron Maiden" };
Dictionary<string, List<int>> listaDeBandas = new Dictionary<string, List<int>>();
listaDeBandas.Add("Metallica", new List<int>() { 10, 8, 7, 10});
listaDeBandas.Add("Kiss", new List<int>() { 8, 10, 8});
listaDeBandas.Add("Iron Maiden", new List<int>());

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
    int opecaoEscolhidaConverte = int.Parse(opecaoEscolhida)!;

    switch(opecaoEscolhidaConverte)
    {
        case 1:  RegistrarBanda();
            break;
        case 2: ListarBandas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            ExibeMedidaDeUmaBanda();
            break;
        case 0:
            ExibeNumero(opecaoEscolhidaConverte);
            break;
        default: Console.WriteLine("opção invalida");
            break;
    }
}

void ExibeNumero(int opecao)
{
    Console.WriteLine("Você escolheu " + opecao);
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpecao("Registra banda");
    Console.Write("Digite o nome da banda que deseja registrar ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDeBandas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda foi registrada com sucesso {nomeDaBanda}");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ListarBandas()
{
    Console.Clear();
    ExibirTituloDaOpecao("Bandas!");
    
    foreach (string banda in listaDeBandas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    
    Console.WriteLine("Pressione qualquer tecla para voltar.");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpecao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = "".PadLeft(quantidadeDeLetras, '*'); 
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloDaOpecao("Avaliar Banda!");
    Console.Write("Digite nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (!listaDeBandas.ContainsKey(nomeDaBanda))
    {
        SeBandaNaoExiste(nomeDaBanda, AvaliarBanda);
    }
    Console.Write($"De sua nota de 0 a 10 a banda {nomeDaBanda}: ");
    int avaliacao = int.Parse(Console.ReadLine()!);
    listaDeBandas[nomeDaBanda].Add(avaliacao);
    Console.WriteLine("Nota registra! Agradecemos a avaliação");
    Thread.Sleep(2500);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibeMedidaDeUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpecao("Media de uma banda!");
    Console.Write("Digite o nome da banda que deseja saber a media: ");
    string nome = Console.ReadLine()!;
    if (!listaDeBandas.ContainsKey(nome))
    {
        SeBandaNaoExiste(nome, ExibeMedidaDeUmaBanda);
    }
    int media = (int)listaDeBandas[nome].Average();
    Console.WriteLine($"A media é {media}");
    Console.WriteLine("Pressione qualquer tecla para voltar ao inicio");
    Console.ReadKey();
    ExibirOpcoesDoMenu();
}

void SeBandaNaoExiste(string nome, Action func)
{
    Console.WriteLine($"Banda *{nome}* não registra ou incorretamente digitada");
    Console.WriteLine("Digite qualquer letra para voltar ao inicio ou R para tentar de novo");
    string op = Console.ReadLine()!;
    if (op == "r" || op == "R")
    {
        func();
        return;
    }
    ExibirOpcoesDoMenu();
}

ExibirOpcoesDoMenu();