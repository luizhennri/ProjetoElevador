using ProjetoElevador.Models;
using System;

namespace ProjetoElevador
{
    internal class Program
    {
        // Programa principal
        static void Main(string[] args)
        {
            // Variáveis
            int op = -1, capMax, numAnd;
            Elevador ele = new Elevador();

            // Interação com o usuário
            while (op != 0)
            {
                // Menu
                Console.Clear();
                Console.WriteLine("---------MENU---------");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("1 - Definir elevador");
                Console.WriteLine("2 - Adicionar uma pessoa no elevador");
                Console.WriteLine("3 - Remover uma pessoa do elevador");
                Console.WriteLine("4 - Subir um andar");
                Console.WriteLine("5 - Descer um andar\n");

                Console.WriteLine($"Andar atual: {ele.andar}; Número de pessoas no elevador: {ele.numeroPessoas}\n");

                Console.Write("Digite uma opção: ");
                op = int.Parse(Console.ReadLine());

                Console.Clear();

                // Realiza uma determinada ação dependendo da escolha do usuário
                switch (op)
                {
                    // Sair do menu
                    case 0:
                        Console.WriteLine("\n--------------Saindo... --------------");
                        break;
                    // O usuário define a capacidade total de pessoas do elevador
                    // e o número total de andares
                    case 1:
                        Console.WriteLine("Digite a capacidade total do elevador: ");
                        capMax = int.Parse(Console.ReadLine());

                        Console.WriteLine("\nDigite o número total de andares do elevador: ");
                        numAnd = int.Parse(Console.ReadLine());

                        Console.WriteLine(ele.Inicializar(capMax, numAnd));
                        break;
                    // Adiciona uma pessoa ao elevador
                    case 2:
                        Console.WriteLine(ele.Entrar());
                        break;
                    // Retira uma pessoa do elevador
                    case 3:
                        Console.WriteLine(ele.Sair());
                        break;
                    // Sobe um andar
                    case 4:
                        Console.WriteLine(ele.Subir());
                        break;
                    // Desce um andar
                    case 5:
                        Console.WriteLine(ele.Descer());
                        break;
                    // Opção fora do menu
                    default:
                        Console.WriteLine("\n--------------Escolha uma opção válida!--------------");
                        break;
                }

                // Pausa no console para o usuário visualizar a mensagem
                Console.WriteLine("\n\nAperte qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
