using System;
using System.Collections.Generic;
using System.Linq;

namespace dotnet_Balta.Aulas
{
    public class Aula06
    {
        internal static void Aula()
        {
            string[] nomes = {
            "Ana",
            "João",
            "Pedro",
            "Paula",
            "Maria",
            "Beatriz"
            };

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine(nomes[i]);
            }

            List<string> cidades = new List<string>
            {
                "São Paulo",
                "Natal",
                "Rio de Janeiro",
                "Brasilia"
            };

            cidades.Add("Gravataí");

            List<string> cidades2 = new List<string>
            {
                "Porto Alegre",
                "Cachoeirinha"
            };

            cidades.AddRange(cidades2);
            
            for (int i = 0; i < cidades.Count; i++)
            {
                Console.WriteLine(cidades[i]);
            }

            var filtro = from item in cidades
            where item.StartsWith("S")
            select item;

            Console.WriteLine("Linq");
            foreach (var item in filtro)
            {
                Console.WriteLine(item);
            }

            var filtradas = cidades.Where(item => item.StartsWith("N"));
            
            foreach (var item in filtradas)
            {
                Console.WriteLine(item);
            }
        }
    }
}