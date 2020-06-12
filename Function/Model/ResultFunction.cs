using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Function.Model
{
    class ResultFunction : INotifyPropertyChanged
    {
        #region Поля
        private double valueX = 0;
        private double valueY = 0;
        private double result = 0;

        #endregion

        #region Свойства
        public double ValueX
        {
            get => valueX;
            set
            {
                valueX = value;
                OnPropertyChanged("ValueX");
            }
        }
        public double ValueY
        {
            get => valueY;
            set
            {
                valueY = value;
                OnPropertyChanged("ValueY");
            }
        }
        public double Result
        {
            get => result;
            set
            {
                result = value;
                OnPropertyChanged("Result");
            }
        }

        #endregion

        public double CalculateResult(AllFunctions function)
        {
            switch (function?.Name)
            {
                case 0://"Линейная"
                    Result = function.CoefficientA * ValueX + function.CoefficientB + function.CoefficientC;
                    break;
                case 1://"Квадратичная"
                    Result = function.CoefficientA * Math.Pow(ValueX, 2)
                        + function.CoefficientB * ValueY
                        + function.CoefficientC;
                    break;
                case 2://"Кубическая"
                    Result = function.CoefficientA * Math.Pow(ValueX, 3)
                        + function.CoefficientB * Math.Pow(ValueY, 2)
                        + function.CoefficientC;
                    break;
                case 3://"Четвертой степени"
                    Result = function.CoefficientA * Math.Pow(ValueX, 4)
                        + function.CoefficientB * Math.Pow(ValueY, 3)
                        + function.CoefficientC;
                    break;
                case 4://"Пятой степени"
                    Result = function.CoefficientA * Math.Pow(ValueX, 5)
                        + function.CoefficientB * Math.Pow(ValueY, 4)
                        + function.CoefficientC;
                    break;
                default:
                    Result = 0;
                    break;
            }
            return Result;
        }

        #region интерфейсы
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        #endregion
    }
}
