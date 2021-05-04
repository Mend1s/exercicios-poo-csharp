using System;

//Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
//médio dos funcionários.

namespace ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func1 = new Funcionario();
            Funcionario func2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            func1.Name = Console.ReadLine();
            Console.Write("Salário: ");
            func1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            func2.Name = Console.ReadLine();
            Console.Write("Salário: ");
            func2.Salario = double.Parse(Console.ReadLine());
            
            Console.WriteLine();
            var media = (func1.Salario + func2.Salario) / 2;
            Console.WriteLine("Salário médio: " + media);

        }
    }
}
