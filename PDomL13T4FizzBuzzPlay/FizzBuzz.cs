using System;
using System.Collections.Generic;
using System.Text;

namespace PDomL13T4FizzBuzzPlay
{
   public class FizzBuzz
    {
        string result;


        public string Result(int myNumber)
        {
            while (true)
            {
                if (myNumber % 3 == 0 && myNumber % 5 == 0)
                {
                    result = "FissBuzz";
                }
                else if (myNumber % 3 == 0)
                {
                    result = "Fiss";
                }
                else if(myNumber % 5 == 0)
                {
                    result = "Buzz";
                }
                else 
                {
                    result = "Liczba " + myNumber.ToString() + " jest niepodzielna ani przez 3 ani 5 ";
                }
                    
               return result;
            }

        }
    }
}
