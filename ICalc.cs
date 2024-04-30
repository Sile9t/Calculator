using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface ICalc
    {
        double _result { get; set; }
        Stack<double> _lastResult { get; set; }
        void Sum(double x);
        void Sub(double x);
        void Pow(double x);
        void Div(double x);
        event EventHandler<EventArgs> calcOpsHandler;
        void PrintResult();
        bool CancelLast();
    }
}
