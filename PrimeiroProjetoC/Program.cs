﻿// Ouvindo Musga
using Microsoft.Win32;

string mensagemDeBoasVindas = (@"
 ▄██████▄  ███    █▄   ▄█    █▄   ▄█     ▄████████                
███    ███ ███    ███ ███    ███ ███    ███    ███                
███    ███ ███    ███ ███    ███ ███▌   ███    ███                
███    ███ ███    ███ ███    ███ ███▌  ▄███▄▄▄▄██▀                
███    ███ ███    ███ ███    ███ ███▌ ▀▀███▀▀▀▀▀                  
███    ███ ███    ███ ███    ███ ███  ▀███████████                
███    ███ ███    ███ ███    ███ ███    ███    ███                
 ▀██████▀  ████████▀   ▀██████▀  █▀     ███    ███                
                                        ███    ███                
   ▄▄▄▄███▄▄▄▄   ███    █▄     ▄████████    ▄██████▄     ▄████████
 ▄██▀▀▀███▀▀▀██▄ ███    ███   ███    ███   ███    ███   ███    ███
 ███   ███   ███ ███    ███   ███    █▀    ███    █▀    ███    ███
 ███   ███   ███ ███    ███   ███         ▄███          ███    ███
 ███   ███   ███ ███    ███ ▀███████████ ▀▀███ ████▄  ▀███████████
 ███   ███   ███ ███    ███          ███   ███    ███   ███    ███
 ███   ███   ███ ███    ███    ▄█    ███   ███    ███   ███    ███
  ▀█   ███   █▀  ████████▀   ▄████████▀    ████████▀    ███    █▀ 
");
//List<string> listaDasBandas = new List<string>();

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Link no Parquinho", new List<int> { 5, 5, 9 });
bandasRegistradas.Add("Os Bezouros", new List<int>());

void ExecutarMensagemInicial()
{
    Console.WriteLine(mensagemDeBoasVindas);
};

void ExibirItensMenu()
{
    Console.Clear();
    ExecutarMensagemInicial();
    Console.WriteLine("Digite 1 para registara uma banda.");
    Console.WriteLine("Digite 2 para mostrar todas as bandas.");
    Console.WriteLine("Digite 3 para avaliar uma banda.");
    Console.WriteLine("Digite 4 para exibir a media de uma banda.");
    Console.WriteLine("Digite 5 para sair.");
    Console.Write("\nDigite aqui sua opção: ");

    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    
    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandas();
            break;
        case 3: AvaliarBandasRegistradas();
            break;
        case 4: MediaDasBandas();
            break;
        case 5: Console.WriteLine("Adeus!");
            break;
        default: Console.WriteLine("Mensagem invalida!");
            break;
    }
};

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloPagina("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar:");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Console.ReadKey();
    Console.Clear();
    ExibirItensMenu();
}

void MostrarBandas()
{
    Console.Clear();
    ExibirTituloPagina("Bandas Registradas");
    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
        //int o = i;
        //Console.WriteLine($"{o+1}ªBanda: {listaDasBandas[i]}");

    //};
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nAperte qualquer tecla para sair");
    Console.ReadKey();
    Console.Clear();
    ExibirItensMenu();
}

void ExibirTituloPagina(string titulo)
{
    int quantidadeDeLetras = (titulo.Length) + 2;
    string charactereIgual = string.Empty.PadLeft(quantidadeDeLetras, '=');
    Console.WriteLine(charactereIgual);
    Console.WriteLine($"={titulo}=");
    Console.WriteLine(charactereIgual + "\n");
}

void AvaliarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloPagina("Avaliador de bandas");
    Console.Write("Digite aqui a banda que você gostaria de avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.WriteLine($"Qual a nota que você vai dar para {nomeDaBanda}: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}.");
        Thread.Sleep(2000);
        ExibirItensMenu();
    }
    else
    {
        Console.WriteLine("\nEssa banda ainda não está registrada. ;-;");
        Console.WriteLine("Aperta um botão para voltar para o menu legal.");
        Console.ReadKey();
        ExibirItensMenu();
    }
}

void MediaDasBandas()
{
    Console.Clear();
    ExibirTituloPagina("Média das bandas");
    Console.WriteLine("\nQual banda você gostaria de saber a média: \n");
    string bandaSelecionada = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(bandaSelecionada))
    {
        var notas = bandasRegistradas[bandaSelecionada];

        if (notas.Count == 0)
        {
            Console.WriteLine("\nEssa banda ainda não tem notas. Seja o primeiro a avaliá-la!");
        }
        else
        {
            int media = (int)notas.Average();
            Console.WriteLine($"\nA média da banda {bandaSelecionada} é: {media}");
        }
    }
    else
    {
        Console.WriteLine("\nEssa banda ainda não está registrada. ;-;");
    }

    Console.WriteLine("Aperte um botão para voltar para o menu.");
    Console.ReadKey();
    ExibirItensMenu();
}


//Execuções
ExibirItensMenu();
