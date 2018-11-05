using System;
namespace CJCal
{
    public class Engine
    {

        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public double NumberInMemory { get; set; }

        public Engine()
        {
            FirstNumber = 1;
            SecondNumber = 5;
            NumberInMemory = 0;
        }

        public double SumNumbers()
        {
            return FirstNumber + SecondNumber;
        }

        public double MultipleNumbers()
        {
            return FirstNumber * SecondNumber;
        }

        public double SumInBetween()
        {
            double result = 0;
            for (var i = FirstNumber; i <= SecondNumber; i++)
            {
                result += i;
            }

            return result;
        }

        public override string ToString()
        {
            string result =
                "First number: " + FirstNumber
                + "\n" + "Second number: " + SecondNumber
                + "\n" + "Number in memory: " + NumberInMemory;

            return result;
        }
    }
}
