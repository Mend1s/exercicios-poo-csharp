﻿using System;

//Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
//velha.

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1, p2;

            p1 = new Pessoa();
            p2 = new Pessoa();

            int x = i;

            Console.WriteLine("Dados da primeira pessoa: ");
            p1.Nome = Console.ReadLine();
            p1.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa: ");
            p2.Nome = Console.ReadLine();
            p2.Idade = int.Parse(Console.ReadLine());


            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + p2.Nome);
            }
        }
    }
}
