using System;

namespace dotnet_Balta.Aulas
{
    public class Aula05
    {
        internal static void Aula()
        {
            object[] parametros = {"Natal", 2015, 800000, 100000000};
            string result = string.Format("{0} em {1}: população {2:N0}, Area {3:N1} m2", parametros);
            Console.WriteLine(result);
        }
    }
}