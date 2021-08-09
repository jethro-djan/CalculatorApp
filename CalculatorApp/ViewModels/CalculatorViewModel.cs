using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CalculatorApp.Models;

namespace CalculatorApp.ViewModels
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        Number number;

        public CalculatorViewModel()
        {
            number = new Number(0);
        }
        double calculator;

        public void GetNumber()
        {

        }

        public void GetBinaryOperation()
        {

        }
    }

    //public class Numberly
    //{
    //    private double _firstly;
    //    public Numberly(object firstNumber) => Firstly = (double)firstNumber;
    //    public double Firstly
    //    {
    //        get => _firstly;
    //        set => _firstly = value;
    //    }

        //public double GetNumber(object number)
        //{
        //    return (double)number;
        //}
    //}
}
