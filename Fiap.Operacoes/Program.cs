using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Operacoes
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Digite seu nome: ");
                string nome = Console.ReadLine();

                Console.Write("Digite um número: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Digite um número 2: ");
                double num2 = double.Parse(Console.ReadLine());

                //Operações Aritiméticos
                double soma = num1 + num2;
                double sub  = num1 - num2;
                double mult = num1 * num2;
                double modulo = num1 % num2;

                Console.WriteLine("\nResultado das Operações Aritiméticos");
                Console.WriteLine($"O valor da soma é {soma}");
                Console.WriteLine($"O valor da subtração é {sub}");
                Console.WriteLine($"O valor da multplicação é {mult}");
                Console.WriteLine($"O valor do modulo (resto) é {modulo}");

                //Operações Relacionais
                bool igual = num1 == num2;
                bool diferente = num1 != num2;
                bool maior = num1 > num2;
                bool menor = num1 < num2;
                bool maiorIgual = num1 >= num2;
                bool menorIgual = num1 <= num2;

                Console.WriteLine("\nResultado das Operações Relacionais");
                Console.WriteLine($"Os números são iguais? {igual}");
                Console.WriteLine($"Os números são diferentes? {diferente}");
                Console.WriteLine($"O numero 1° é maior que o 2°? {maior}");
                Console.WriteLine($"O numero 1° é menor que o 2°? {menor}");

                //Operações Lógicas
                bool ambosPositivos = num1>0 && num2>0;
                bool nenhumNegativo = !(num1 < 0 || num2 < 0);

                Console.WriteLine("\nResultado das Operações Lógicas");
                Console.WriteLine($"Os números são ambos positivos? {ambosPositivos}");
                Console.WriteLine($"Nenhum dos números é negativo? {nenhumNegativo}");

                Console.Write("Digite qualquer coisa pra sair");

            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
