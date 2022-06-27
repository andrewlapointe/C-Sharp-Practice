namespace Calculator
{
    class Calculator
    {
        public static void ManageCalculator()
        {
            double[] inputNumbers = new double[2];
            string? operationType;
            string result;

            while (true) 
            {

                Console.WriteLine("What operation would you like to preform?");
                Console.WriteLine("add, subtract, multiply, divide, quit");
                Console.Write("> "); operationType = Console.ReadLine().ToLower();

                if (operationType == "quit" || operationType == "exit" || operationType == "end")
                {
                    break;
                }

                Console.WriteLine("Enter first number");
                Console.Write("> "); inputNumbers[0] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter second number");
                Console.Write("> "); inputNumbers[1] = Convert.ToDouble(Console.ReadLine());

                if (operationType == "add" || operationType == "addition")
                {
                    result = Convert.ToString(Add(inputNumbers));
                } 
                else if (operationType == "subtract" || operationType == "subtraction")
                {
                    result = Convert.ToString(Subtract(inputNumbers));
                }
                else if (operationType == "multiply" || operationType == "multiplication")
                {
                    result = Convert.ToString(Multiply(inputNumbers));
                }
                else if (operationType == "divide" || operationType == "division")
                {
                    result = Divide(inputNumbers);
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
        
        private static string Divide(double[] args)
        {
            double dividend = args[0];
            double divisor = args[1];
            string quotient;

            if (divisor == 0)
            {
                return "Undefined";
            } else {
                quotient = Convert.ToString(dividend / divisor);
                return quotient;
            }

            
        }
    }
}