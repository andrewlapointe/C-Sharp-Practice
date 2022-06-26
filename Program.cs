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

            Console.WriteLine("What operation would you like to preform?");
            Console.WriteLine("add, subtract, multiply, divide");
            Console.Write("> "); operationType = Console.ReadLine();

            Console.WriteLine("Enter first number");
            Console.Write("> "); inputNumbers[0] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number");
            Console.Write("> "); inputNumbers[1] = Convert.ToDouble(Console.ReadLine());

            if (operationType.ToLower() == "add" || operationType.ToLower() == "addition")
            {
                result = Convert.ToString(Add(inputNumbers));
            } else {
                result = "Error";
            }



            Console.WriteLine("The result is: " + result);

        }

        private static double Add(double[] args)
        {
            double[] addends = {args[0], args[1]};
            double sum;

            sum = addends[0] + addends[1];

            return sum;
        }
    }
}