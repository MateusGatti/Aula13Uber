using System;

namespace Aula13Uber
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Passageiro mateus = new Passageiro();
            Corrida corrida = new Corrida();

            Motorista joao = new Motorista();


            System.Console.WriteLine("Digite o seu login:");
            string login = Console.ReadLine();

            System.Console.WriteLine("Digite a sua senha:");
            string senha = Console.ReadLine();

            mateus.Login(login, senha);

            if( mateus.TokenLogin != "" && mateus.TokenLogin != null ){
                System.Console.WriteLine("Login autorizado!");
                System.Console.WriteLine("Seu token: "+mateus.TokenLogin);
            }else{
                System.Console.WriteLine("Não foi possível logar");
                // não consegui fazer com que o programa pare aqui, caso o login nao seja certo
                
                
            }

            System.Console.WriteLine("Digite 1 para motorista ou 2 para passageiro");
            int resposta = int.Parse( Console.ReadLine() );

            switch(resposta){
                case 1:
               System.Console.WriteLine("Você é um motorista!");

               //System.Console.WriteLine(joao.aceitarPassageiro);

               //travei aqui

               

               
                
                
                
                
                

                break;






                case 2:
                System.Console.WriteLine("Digite sua localização");
                corrida.localInicio = Console.ReadLine();
                System.Console.WriteLine("Digite a localização que deseja ir");
                corrida.localChegada = Console.ReadLine();

                //travei aqui

                
                break;
                

            }
            
                

            
            

        }
    }
}
