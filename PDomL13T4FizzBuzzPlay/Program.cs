using System;

namespace PDomL13T4FizzBuzzPlay
{
    class Program
    {
        private static string result;
        private static string toStop;
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Podaj liczbe");
                    int myNumber = int.Parse(Console.ReadLine());
                    var fizzBuzz = new FizzBuzz();
                    result = fizzBuzz.Result(myNumber);
                    Console.WriteLine(result);

                    Console.WriteLine("Nacisnij Enter aby kontynuwac lub Y jeli chcesz ewentualnie przerwac gre.");
                    toStop = Console.ReadLine();
                    if (toStop == "y")
                    {
                        Console.WriteLine("Nacisnales Y i gra zostaje przerwana");
                        break;
                    }

                }
                catch
                {
                    Console.WriteLine("Podana wartosc nie jest prawdopodobnie liczba :(");

                }
                
            }

        }
    }
}
