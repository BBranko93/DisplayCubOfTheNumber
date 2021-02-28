using System;

namespace DisplayCubOfTheNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            int termsNumber;
            string givenInput = "";
            bool testIfInteger = false;

            Console.WriteLine("Input number of terms : ");
            givenInput = Console.ReadLine();

            testIfInteger = int.TryParse(givenInput, out termsNumber);
            
            //if(testIfIntager==false)
            if (!testIfInteger)
            {
                Console.WriteLine("Please enter a number not letters!!!");
                termsNumber = int.Parse(Console.ReadLine());
            }
            CubeCalc(termsNumber);
        }

        public static void CubeCalc(int value)
        {
            int i;

            for (i = 1; i <= value; i++) 
            {
                var result = i * i * i;
                Console.WriteLine("Number is : " + i.ToString() + " and the cube of the " + i.ToString() + " is " + result.ToString());
            }
        }
    }
}
