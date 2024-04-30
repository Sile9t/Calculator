using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calc();
            calc.calcOpsHandler += CalcEventHandler;
            bool exit = false;
            calc.Sum(Input());
            while (!exit)
            {
                PrintOperations();
                char op = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (op)
                {
                    case '+':
                        calc.Sum(Input());
                        break;
                    case '-':
                        calc.Sub(Input());
                        break;
                    case '*':
                        calc.Pow(Input());
                        break;
                    case '/':
                        calc.Div(Input());
                        break;
                    case '<':
                         exit = !calc.CancelLast();
                        break;
                    case 'q':
                        exit = true;
                        break;
                }
            }
            Console.WriteLine("Exit the app");
        }
        public static double Input()
        {
            double num = 0D;
            Console.WriteLine("Enter a number");
            while (!double.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("It is not a number! Try again.");
            }
            return num;
        }
        public static void PrintOperations()
        {
            Console.WriteLine("Choose operation:");
            Console.WriteLine("'+' - summatoring");
            Console.WriteLine("'-' - substraction");
            Console.WriteLine("'*' - powering");
            Console.WriteLine("'/' - division");
            Console.WriteLine("'<' - cancel last");
            Console.WriteLine("'q' - to exit");
        }
        private static void CalcEventHandler(object? sender, EventArgs e)
        {
            if (sender is Calc)
                Console.WriteLine(((Calc)sender)._result);
        }
    }
}
