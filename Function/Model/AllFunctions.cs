using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Function.Model
{
    class AllFunctions : INotifyPropertyChanged
    {
        #region Поля
        private double _coefficientA = 0;
        private double _coefficientB = 0;
        private int _coefficientC = 0;

        #endregion

        #region Свойства
        public int Name { get; set; } = 0;
        public double CoefficientA
        {
            get => _coefficientA;
            set
            {
                _coefficientA = value;
                OnPropertyChanged("CoefficientA");
            }
        }
        public double CoefficientB
        {
            get => _coefficientB;
            set
            {
                _coefficientB = value;
                OnPropertyChanged("CoefficientB");
            }
        }
        public int CoefficientC
        {
            get => _coefficientC;
            set
            {
                _coefficientC = value;
                OnPropertyChanged("CoefficientC");
            }
        }

        #endregion

        #region интерфейсы
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        #endregion
    }
}
