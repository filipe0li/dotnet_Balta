using System;

namespace dotnet_Balta.Aulas
{
    public class Aula03
    {
        internal static void Aula()
        {
            // Precisão:
            float flo = 3.12341234F * 2;
            double dou = 3.1234123412341234D * 2;
            decimal dec = 3.12341234123412341234M * 2;

            Console.WriteLine(flo);
            Console.WriteLine(dou);
            Console.WriteLine(dec);
        }
    }
}