using System;

namespace dotnet_Balta.Aulas
{
    public class Aula02
    {
        internal static void Aula()
        {
            int[] num = ColocaoNum();
            Iteracao(num);
        }
        static int[] ColocaoNum()
        {
            return new int[] { 1, 2, 3, 4 };
        }
        static void Iteracao(int[] num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i].ToString("00"));
            }
        }
    }
}