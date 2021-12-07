using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {

       enum Menu {Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair}




        static void Main(string[] args)
        {

            bool escolheusair = false;  
            while(!escolheusair) //Enquanto o Usuario não escolher sair, exiba o menu!
            
            {

                Console.WriteLine("Bem Vindo a CALC! Selecione uma das opções abaixo:");
                Console.WriteLine("1-soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potencia\n6-Raiz\n7-sair");

                //string opcaoTXT = Console.ReadLine();
                //int opcaoint = int.Parse(opcaoTXT);
                //Menu opcao = (Menu)opcaoint;


                Menu opcao = (Menu)int.Parse(Console.ReadLine());
                
                switch(opcao)
                {
                    case Menu.Sair:
                        escolheusair=true;
                        break;

                    case Menu.Soma:
                        Soma();
                        break;

                    case Menu.Subtracao:
                        Subtracao();
                        break;

                    case Menu.Divisao:
                        Divisao();
                        break;

                    case Menu.Multiplicacao:
                        Multiplicacao();
                        break;

                    case Menu.Potencia:
                        Pot();
                        break;
                    case Menu.Raiz:
                        raiz();
                        break;

                    

                }   
                
                Console.Clear();
               

            }

            
        }

        static void Soma()
        {
            Console.WriteLine("Soma de dois numeros");
            Console.WriteLine("Digite o Primeiro Numero:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine("O resultado é:" + resultado);
            Console.WriteLine("Pressione ENTER para voltar ao menu");
            Console.ReadLine();

        }

        static void Subtracao()
        {
            Console.WriteLine("Subtração");
            Console.WriteLine("Digite o primeiro numero:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine("O resultado da Subtração é:" + resultado);
            Console.WriteLine("Pressione ENTER para voltar ao menu");
            Console.ReadLine();

        }

        static void Divisao()
        {
            Console.WriteLine("Divisão");
            Console.WriteLine("Digite o primeiro numero:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a/(float)b;
            Console.WriteLine("o resultado é:" + resultado);
            Console.WriteLine("Pressione ENTER para voltar ao menu");
            Console.ReadLine();

        }

        static void Multiplicacao()
        {
            Console.WriteLine("Multiplicação");
            Console.WriteLine("Escolha o primeiro numero:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha o segundo numero:");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine("O resultado é:" + resultado);
            Console.WriteLine("Pressione ENTER para voltar ao menu");
            Console.ReadLine();

        }

        static void Pot()
        {
            Console.WriteLine("Potencia");
            Console.WriteLine("Digite a base:");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente");
            int expo = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNum, expo);
            Console.WriteLine("O resultado é:" + resultado);
            Console.WriteLine("Pressione ENTER para voltar ao menu");
            Console.ReadLine();

        }


        static void raiz()
        {
            Console.WriteLine("Raiz Quadrada");
            Console.WriteLine("Escolha um numero");
            int a = int.Parse(Console.ReadLine());

            double resultado = Math.Sqrt(a);
            Console.WriteLine("O resultado é:" + resultado);
            Console.WriteLine("Pressione ENTER para voltar ao menu");
            Console.ReadLine();

        }

    }
}
