using System.Runtime;
using Estacionamento;
using Microsoft.VisualBasic;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal PrecoporHora = 0;
decimal PrecoInicial = 0;


  Console.WriteLine("Seja Bem Vindo ao nosso estacionamento!");
  
  Console.WriteLine("Digite o preço inicial de entrada de veículos");
    
    PrecoInicial=Convert.ToDecimal(Console.ReadLine());
  
  Console.WriteLine("Digite o valor por hora estabelecido");
   
    PrecoporHora=Convert.ToDecimal(Console.ReadLine());


List<string> veiculos = new List<string>();

  EstacionamentoControle es = new EstacionamentoControle(PrecoInicial, PrecoporHora, veiculos);
  
Console.Clear();

Menu adicionar = new Menu();

string Primeira = adicionar.Primeira;
string segunda = adicionar.Segunda;
string terceira = adicionar.terceira;
string quarta = adicionar.quarta;

  while (true)
            {
                Console.Clear();
                Console.WriteLine($"{Primeira} \n {segunda} \n {terceira} \n {quarta} ");
                string opcao = Console.ReadLine();

 
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Digite uma placa para continuar:");
                        
                        es.Placa();
                        
                        Console.WriteLine("Veículo adicionado com sucesso!");
                        break;

                    case "2":
                        Console.WriteLine("Veículos cadastrados:");
                       es.veiculosCadastrados();
                       
                        break;

                    case "3":
                        Console.WriteLine("Retirar veiculos");
                        es.retirarVeiculos();
                        foreach(string item in veiculos){
                            Console.WriteLine(item);
                        }
                        Console.WriteLine($"veículo retirado com sucesso: o valor a ser pago ficou {PrecoInicial * PrecoporHora}");
                        break;

                    case "4":

                    Console.WriteLine("Sair do programa");

                     return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                // Aguarda até que o usuário pressione uma tecla para continuar
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
         
            }
            