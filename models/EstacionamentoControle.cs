using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Estacionamento
{
    public class EstacionamentoControle
    {
       private decimal PrecoInicial = 0;

       private decimal PrecoporHora = 0;

       List<string> veiculos = new List<string>();

       public EstacionamentoControle(decimal PrecoInicial, decimal PrecoPorHora, List<string>veiculos){

        this.PrecoInicial = 0;
        this.PrecoporHora = 0;
        
       }


      public void Placa(){
       
       veiculos.Add(Console.ReadLine());
      }
         
      public void veiculosCadastrados(){
        foreach (string item in veiculos){
            Console.WriteLine(item);
            
        }
        if(veiculos.Count == 0){
            Console.WriteLine("Nao ha veiculos");



        }else {
            Console.WriteLine("Ha veiculos");
        }
      }
       public void retirarVeiculos(){
        veiculos.Clear();
       }
      }   
   
    }
     

     


     
     
     
     
     
     
     
     
     
     
     
     public class Menu {
         public string Primeira ="1 - Cadastrar veículo ";
         public string Segunda ="2 - Mostrar veículos";
         public string terceira ="3 - retirar veículos";
         public string quarta ="4 - Sair";
     
     }
      
    

