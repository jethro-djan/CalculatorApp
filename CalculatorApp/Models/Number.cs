using System;
namespace CalculatorApp.Models
{
    public class Number
    {
        private double _first = 0;
        public Number(double firstNumber) => First = firstNumber;

        public double First
        {
            get => _first;
            set => _first = value;
        }

        public double Add(object number)
        {
            return _first + (double)number;
        }

    }
}
