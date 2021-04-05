using System;

namespace dotnet_Balta.Aulas
{
    public class Aula01
    {
        internal static void Aula()
        {
            // Referência antes:
            int[] num = new int[4];

            // Agrega valor:
            num = new int[] { 1, 2, 3, 4 };

            // Referência e agraga valor:
            int[] num0 = { 1, 2, 3, 4 };

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }

            int temp = 0;
            while (temp < num.Length)
            {
                Console.WriteLine(num[temp]);
                temp++;
            }

            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
        }
    }
}