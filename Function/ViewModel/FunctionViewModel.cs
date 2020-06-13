using Function.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Function.ViewModel
{
    /// <summary>
    /// Класс, для отображения функций ввиде списка данных
    /// </summary>
    class FunctionViewModel : INotifyPropertyChanged
    {
        #region Поля
        private AllFunctions _selectedFunction;
        public ObservableCollection<ResultFunction> _resultFunctions;

        #endregion

        #region Свойства
        public AllFunctions SelectedFunction
        {
            get => _selectedFunction;
            set
            {
                _selectedFunction = value;
                OnPropertyChanged("SelectedFunction");
            }
        }
        public ObservableCollection<AllFunctions> AllFunctions { get; set; }
        public ObservableCollection<ResultFunction> ResultFunctions
        {
            get => _resultFunctions;
            set
            {
                _resultFunctions = value;
                OnPropertyChanged("ResultFunctions");
            }
        }

        #endregion

        #region Конструктор
        public FunctionViewModel()
        {
            AllFunctions = new ObservableCollection<AllFunctions>
            {
               //Значения для проверки
               new AllFunctions { },
               new AllFunctions { Name = 1 },
               new AllFunctions { Name = 2 },
               new AllFunctions { Name = 3 },
               new AllFunctions { Name = 4 }
            };

            ResultFunctions = new ObservableCollection<ResultFunction>
            {
                //Значения для примера
                new ResultFunction{ ValueX = -2, ValueY = -2, Result = 0 },
                new ResultFunction{ ValueX = -1, ValueY = -1, Result = 0 },
                new ResultFunction{ ValueX = 0, ValueY = 0, Result = 0 },
                new ResultFunction{ ValueX = 1, ValueY = 1, Result = 0 },
                new ResultFunction{ ValueX = 2, ValueY = 2, Result = 0 }
            };
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
