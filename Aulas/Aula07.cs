using System;
using System.Collections.Generic;
using System.Linq;

namespace dotnet_Balta.Aulas
{
    public class Aula07
    {
        internal static void Aula()
        {
            Dictionary<string, string> capitais = new Dictionary<string, string>();
            capitais.Add("RN", "Natal");
            capitais.Add("SP", "São Paulo");
            capitais.Add("RJ", "Rio de Janeiro");
            capitais.Add("RS", "Porto Alegre");

            Console.WriteLine(capitais["RN"]);

            var UF = capitais.Keys.Where(item => item.StartsWith("R"));

            foreach (var item in UF)
            {
                Console.WriteLine(item);
            }

            var capital = capitais.Values.Where(item => item.StartsWith("R"));

            foreach (var item in capital)
            {
                Console.WriteLine(item);
            }

            var teste = new Dictionary<DateTime, List<float>>(); // É redundate, use VAR.
            teste.Add(new DateTime(2021, 04, 22), new List<float>{2900.00F, 610.00f});

            var teste1 = teste[new DateTime(2021, 04, 22)];

            foreach (var item in teste1)
            {
                Console.WriteLine(item);
            }
        }
    }
}