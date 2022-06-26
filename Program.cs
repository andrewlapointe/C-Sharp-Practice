// See https://aka.ms/new-console-template for more information
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputNumbers = new double[2];
            string operationType;
            string result;

            while (true) {

                Console.WriteLine("What operation would you like to preform?");
                Console.WriteLine("add, subtract, multiply, divide, quit");
                Console.Write("> "); operationType = Console.ReadLine();

                if (operationType.ToLower() == "quit" || operationType.ToLower() == "exit" || operationType.ToLower() == "end")
                {
                    break;
                }

                Console.WriteLine("Enter first number");
                Console.Write("> "); inputNumbers[0] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter second number");
                Console.Write("> "); inputNumbers[1] = Convert.ToDouble(Console.ReadLine());

                if (operationType.ToLower() == "add" || operationType.ToLower() == "addition")
                {
                    result = Convert.ToString(Add(inputNumbers));
                } 
                else if (operationType.ToLower() == "subtract" || operationType.ToLower() == "subtraction")
                {
                    result = Convert.ToString(Subtract(inputNumbers));
                }
                else if (operationType.ToLower() == "multiply" || operationType.ToLower() == "multiplication")
                {
                    result = Convert.ToString(Multiply(inputNumbers));
                }
                else if (operationType.ToLower() == "divide" || operationType.ToLower() == "division")
                {
                    result = Convert.ToString(Divide(inputNumbers));
                } else {
                    result = "Error. Try again.";
                }

                Console.WriteLine("The result is: " + result);
            }

        }

        private static double Add(double[] args)
        {
            double[] addends = {args[0], args[1]};
            double sum;

            sum = addends[0] + addends[1];

            return sum;
        }

        private static double Subtract(double[] args)
        {
            double minuend = args[0];
            double subtrahend = args[1];
            double difference;

            difference = minuend - subtrahend;
            
            return difference;
        }

        private static double Multiply(double[] args)
        {
            double multiplicand = args[0];
            double multiplier = args[1];
            double product;

            product = multiplicand * multiplier;

            return product;
        }
        
        private static double Divide(double[] args)
        {
            double dividend = args[0];
            double divisor = args[1];
            double quotient;

            quotient = dividend / divisor;

            return quotient;
        }
    }
}