using System;
using dotnet_Balta.Aulas;

namespace dotnet_Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            bool start = true;
            while (start)
            {
                Console.WriteLine("Qual aula deseja acessar?");
                int nAula = 0;
                int.TryParse(Console.ReadLine(), out nAula);
                Console.Clear();

                switch (nAula)
                {
                    case 0:
                        Aula00.Aula();
                        break;

                    case 1:
                        Aula01.Aula();
                        break;

                    case 2:
                        Aula02.Aula();
                        break;

                    case 3:
                        Aula03.Aula();
                        break;

                    case 4:
                        Aula04.Aula();
                        break;

                    case 5:
                        Aula05.Aula();
                        break;

                    case 6:
                        Aula06.Aula();
                        break;

                    case 7:
                        Aula07.Aula();
                        break;
                    default:
                        start = false;
                        break;
                }
            }

            //Console.ReadLine();
        }
    }
}
