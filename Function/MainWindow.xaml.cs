using Function.Model;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Function
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int IndexCoefficientC { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Closing += MainWindow_Closing;
        }

        /// <summary>
        /// Действие, при загрузке окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = new FunctionViewModel();//при загрузке окна, добавлять данные
        }
        private void MainWindow_Closing(object sender, CancelEventArgs e) { }

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
            DataContext = new Actions().CalculateResult((FunctionViewModel)DataContext);

            SelectedCoefficientC.Items.Clear();//очищаю список

            if (SelectedIndex == 0)
                for (var index = 1; index < 6; index++)
                    SelectedCoefficientC.Items.Add(index);//добвляю в список нужные элементы
            else
                for (var index = 10; index < 60; index += 10)
                    SelectedCoefficientC.Items.Add(index);
        }
    }
}
