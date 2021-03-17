using System;
using System.Collections.Generic;
using System.Text;

namespace PDomL13T4FizzBuzzPlay
{
   public class FizzBuzz
    {
        string result;


        public string Result()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Podaj liczbe");
                    int myNumber = int.Parse(Console.ReadLine());
                    if (myNumber % 3 == 0)
                    {
                       result = "Fiss";
                    }
                    else if(myNumber % 5 == 0)
                    {
                        result = "Buzz";
                    }
                    else if (myNumber % 3 == 0 && myNumber % 5 == 0)
                    {
                        result = "FissBuzz";
                    }
                    else 
                    {
                        result = "Liczba " + myNumber.ToString() + " jest niepodzielna ani przez 3 ani 5 ";
                    }

                }
                catch
                {
                    Console.WriteLine("Podana wartosc nie jest prawdopodobnie liczba :(");

                }
               return result;
            }

        }
    }
}
