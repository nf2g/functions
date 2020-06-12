using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Function.Model
{
    class AllFunctions : INotifyPropertyChanged
    {
        #region Поля
        private double coefficientA = 0;
        private double coefficientB = 0;
        private int coefficientC = 0;
        #endregion

        #region Свойства
        public int Name { get; set; } = 0;
        public double CoefficientA
        {
            get => coefficientA;
            set
            {
                coefficientA = value;
                OnPropertyChanged("CoefficientA");
            }
        }
        public double CoefficientB
        {
            get => coefficientB;
            set
            {
                coefficientB = value;
                OnPropertyChanged("CoefficientB");
            }
        }
        public int CoefficientC
        {
            get => coefficientC;
            set
            {
                coefficientC = value;
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
