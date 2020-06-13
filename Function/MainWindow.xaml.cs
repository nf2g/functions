using Function.Model;
using Function.View;
using Function.ViewModel;
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
    }
}
