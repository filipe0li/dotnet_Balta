using System;

namespace dotnet_Balta.Aulas
{
    public class Aula04
    {
        internal static void Aula()
        {
            DateTime data = new DateTime(year: 2021, day: 8, month: 3);
            Console.WriteLine(data.ToLongDateString());
            Console.WriteLine(data.ToString("dd . yyyy . MM"));
            Console.WriteLine(data.ToString("dd . yyyy . MM - hh:mm:ss"));
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today.AddDays(-2));
            Console.WriteLine((DateTime.Today - new DateTime(2021,01,01)).Days);
            Console.WriteLine(DateTime.Today - TimeSpan.FromDays(2));
        }
    }
}