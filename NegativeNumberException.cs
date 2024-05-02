using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException() : base()
        {

        }
        public NegativeNumberException(string? message) : base(message)
        {

        }
    }
}
