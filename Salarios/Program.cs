using System;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando o vetor
            funcionarios[] vect = new funcionarios[100];
            //Declarando o numero de Funcionarios
            Console.WriteLine("Digite o numero de Funcionarios a ser registrado: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine(" ");
                //Declarando informações dos funcionarios
                Console.WriteLine($"Funcionario#{i}");
                Console.WriteLine("Id:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Nome:");
                string nome = Console.ReadLine();
                Console.WriteLine("Salario:");
                double salario = double.Parse(Console.ReadLine());

                vect[id] = new funcionarios(nome, salario, id);
            }
            Console.WriteLine("");
            //declarando o aumento para o funcionario
            Console.WriteLine("Id do funcionário receberá aumento: ");
            int id2 = int.Parse(Console.ReadLine());

            if (vect[id2] != null)
            {
                //Função para realizar o aumento
                Console.WriteLine("Porcentagem de aumento de salario: ");
                double porcentagem = double.Parse(Console.ReadLine());
                porcentagem = porcentagem + 100;
                vect[id2].AumentarSalario(porcentagem);
            }
            else
            {
                //Caso id esteja errado
                Console.WriteLine("Este funcionario não existe!");
            }
            //Atualização da lista
            Console.WriteLine("Lista atualizada dos funcionarios da Bravo: ");
            for (int i = 0; i < x + 1; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(vect[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
