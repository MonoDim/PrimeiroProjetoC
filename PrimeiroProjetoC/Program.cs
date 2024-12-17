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

void ExecutarMensagemInicial()
{
    Console.WriteLine(mensagemDeBoasVindas);
};

void ExibirItensMenu()
{
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
        case 1: MensagemOpcaoEscolhida(opcaoEscolhidaNumerica);
            break;
        case 2: MensagemOpcaoEscolhida(opcaoEscolhidaNumerica);
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


ExecutarMensagemInicial();
ExibirItensMenu();
