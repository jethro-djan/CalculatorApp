using System;
namespace CalculatorApp.Models
{
    public class Calculator
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        public float Add(float number1, float number2)
        {
            return number1 + number2;
        }

        public double Add(object number1, object number2)
        {
            return (double)number1 + (double)number2;
        }

        public int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }

        public double Subtract(double number1, double number2)
        {
            return number1 - number2;
        }

        public float Subtract(float number1, float number2)
        {
            return number1 - number2;
        }

        public double Subtract(object number1, object number2)
        {
            return (double)number1 - (double)number2;
        }

        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        public double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }

        public float Multiply(float number1, float number2)
        {
            return number1 * number2;
        }

        public double Multiply(object number1, object number2)
        {
            return (double)number1 * (double)number2;
        }

        public double Divide(int number1, int number2)
        {
            double result = 0;
            try
            {
                result = (double)number1 / (double)number2;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Attempted to divide by zero", ex.Message);
            }
            return result;
        }

        public double Divide(double number1, double number2)
        {
            double result = 0;
            try
            {
                result = (double)number1 / (double)number2;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Attempted to divide by zero", ex.Message);
            }
            return result;
        }

        public float Divide(float number1, float number2)
        {
            float result = 0;
            try
            {
                result = (float)number1 / (float)number2;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Attempted to divide by zero", ex.Message);
            }
            return result;
        }

        public double Divide(object number1, object number2)
        {
            double result = 0;
            try
            {
                result = (double)number1 / (double)number2;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Attempted to divide by zero", ex.Message);
            }
            return result;
        }
    }

    //public class IllegalArgumentException : Exception
    //{
    //    public IllegalArgumentException(string number) : base($"{number} is not a number type")
    //    {

    //    }
    //}
}
