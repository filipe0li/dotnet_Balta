using System;

namespace dotnet_Balta.Aulas
{
    public class Aula00
    {
        internal static void Aula()
        {
            string nome = "Filipe";
            int idade = DateTime.Today.Year - 1991;
            idade = 0;
            if (idade <= 0)
            {
                Console.WriteLine("Idade inválida!");
                return;
            }
            if (DateTime.Today.Month < 8) { idade--; }

            string maiorIdade = idade >= 18 ? "é maior de idade" : "não é maior de idade";
            Console.WriteLine($"{nome} tem {idade} anos e {maiorIdade}.");
        }
    }
}