// Ouvindo Musga
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
List<string> listaDasBandas = new List<string>();

void ExecutarMensagemInicial()
{
    Console.WriteLine(mensagemDeBoasVindas);
};

void ExibirItensMenu()
{
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
        case 3: MensagemOpcaoEscolhida (opcaoEscolhidaNumerica);
            break;
        case 4: MensagemOpcaoEscolhida(opcaoEscolhidaNumerica);
            break;
        case 5: Console.WriteLine("Adeus!");
            break;
        default: Console.WriteLine("Mensagem invalida!");
            break;
    }
};

void MensagemOpcaoEscolhida(int opcaoEscolhidaNumerica)
{
    Console.WriteLine($"Você escolheu a opção: {opcaoEscolhidaNumerica}");
};

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("====================");
    Console.WriteLine("=Registro de bandas=");
    Console.WriteLine("====================\n");
    Console.Write("Digite o nome da banda que deseja registrar:");
    string nomeDaBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Console.ReadKey();
    Console.Clear();
    ExibirItensMenu();
}

void MostrarBandas()
{
    Console.Clear();
    Console.WriteLine("====================");
    Console.WriteLine("=Bandas Registradas=");
    Console.WriteLine("====================\n");
    for (int i = 0; i < listaDasBandas.Count; i++)
    {
        int o = i;
        Console.WriteLine($"{o+1}ªBanda: {listaDasBandas[i]}");

    };
    Console.WriteLine("\nAperte qualquer tecla para sair");
    Console.ReadKey();
    Console.Clear();
    ExibirItensMenu();
}

//Execuções
ExibirItensMenu();
