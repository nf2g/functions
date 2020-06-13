using Function.Model;
using Function.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Function.View
{
    /// <summary>
    /// Логика взаимодействия для ViewFunction.xaml
    /// </summary>
    public partial class ViewFunction : UserControl
    {
        public ViewFunction()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Автоматический подсчет результата
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewCalculateResult(object sender, RoutedEventArgs e)
        {
            new Actions().CalculateResult((FunctionViewModel)DataContext);
        }

        /// <summary>
        /// Действие, которое срабатывает при выборе функции
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var DataListBox = (ListBox)sender;//беру данные листбокса
            var SelectedIndex = DataListBox.SelectedIndex;//преобразую в индекс

            //получаем данные
            new Actions().AddFunction((FunctionViewModel)DataContext, SelectedIndex);//Добавляем функцию в список, если её там нет
            DataContext = new Actions().ChooseFunction((FunctionViewModel)DataContext, SelectedIndex);//Задаем "выбранную" функцию

            SelectedCoefficientC?.Items.Clear();

            if (SelectedIndex == 0)
                for (var index = 1; index < 6; index++)
                    SelectedCoefficientC?.Items.Add(index);//добвляю в список нужные элементы
            else
                for (var index = 10; index < 60; index += 10)
                    SelectedCoefficientC?.Items.Add(index);

        }

    }

}
