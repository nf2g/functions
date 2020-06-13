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
    /// Логика взаимодействия для ViewResult.xaml
    /// </summary>
    public partial class ViewResult : UserControl
    {
        public ViewResult()
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
    }
}
