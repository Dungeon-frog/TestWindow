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
using ZakazLibruary;

namespace TestWindow
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        private ListOrder lo;
        public MainWindow()
        {
            InitializeComponent();
            lo = new ListOrder();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lo.Add(num.Text);
            table.Text = lo.updateTable();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {
            lo.Delete(num.Text);
            table.Text = lo.updateTable();
        }

    }
}
