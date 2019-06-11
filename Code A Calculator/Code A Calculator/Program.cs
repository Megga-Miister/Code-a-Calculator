using System;

namespace Code_A_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose what type of calculation you would like: Add, Subtract, Multiply or Divide");
            string calculate = Console.ReadLine();


            //Console.WriteLine("Please enter what number you would like to " + calculate + ".");
            //string stringA = Console.ReadLine();
            //int numberA = Convert.ToInt32(stringA);

            //Console.WriteLine("Please enter the other number you would like to " + calculate + " with.");
            //string stringB = Console.ReadLine();
            //int numberB = Convert.ToInt32(stringB);
        }

        static int Add(int givenNumberA, int givenNumberB)
        {
            int sum = givenNumberA + givenNumberB;
            return sum;
        }

        //static int Subtract(int givenNumberA, int givenNumberB)
        //{

        //}

        //static int Multiply(int givenNumberA, int givenNumberB)
        //{

        //}

        //static int Divide(int givenNumberA, int givenNumberB)
        //{

        //}
    }
}