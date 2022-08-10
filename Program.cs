using System;

namespace willian
{
    class Program
    {
        static void Main(string[] args)
        {
            int ativador = 1;
            for(ativador=1; ativador==1;){
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("Digite um número, irei dizer se ele é positivo, negativo ou igual a zero!");
                Console.WriteLine("----------------------------------------------------------------------------");
                int number = int.Parse(Console.ReadLine());
                if(number > 0){
                    Console.WriteLine("O número é maior que zero!");
                }else if(number < 0){
                    Console.WriteLine("O número é menor que zero!");
                }else{
                    Console.WriteLine("O número é igual a zero!");
                }
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("Deseja jogar novamente?");
                string resposta = Console.ReadLine();
                if(resposta != "sim"){
                    ativador = 0;
                }
                Console.Clear();
            }
        }
    }
}
