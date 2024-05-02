using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calc : ICalc
    {
        public double _result { get; set; } = 0D;
        public Stack<double> _lastResult { get; set; } = new Stack<double>();

        public event EventHandler<EventArgs>? calcOpsHandler;
        public void PrintResult()
        {
            Console.Write("Result: ");
            calcOpsHandler?.Invoke(this, new EventArgs());
            Console.WriteLine();
        }
        public bool CancelLast()
        {
            if (_lastResult.TryPop(out double res)) 
            {
                _result = res;
                Console.WriteLine("Last operation is canceled. Result: ");
                PrintResult();
                return true;
            }
            Console.WriteLine("No last operations.");
            return false;
        }

        public void Div(double x)
        {
            if (x == 0) throw new DivideByZeroException();
            if (x < 0) throw new NegativeNumberException();
            _result /= 1.0 * x;
            _lastResult.Push(_result);
            PrintResult();
        }

        public void Pow(double x)
        {
            if (x < 0) throw new NegativeNumberException();
            _result *= x;
            _lastResult.Push(_result);
            PrintResult();
        }

        public void Sub(double x)
        {
            if (x < 0) throw new NegativeNumberException();
            _result -= x;
            _lastResult.Push(_result);
            PrintResult();
        }

        public void Sum(double x)
        {
            if (x < 0) throw new NegativeNumberException();
            _result += x;
            _lastResult.Push(_result);
            PrintResult();
        }
    }
}
