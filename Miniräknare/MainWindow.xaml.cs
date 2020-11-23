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

namespace Miniräknare
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string input = string.Empty;
        string tal1 = string.Empty;
        string tal2 = string.Empty;
        char operation;
        double result = 0.0;
        public MainWindow()

        {
            InitializeComponent();
        }
        private void Button_Clear(object sender, RoutedEventArgs e)
        {
            
        }

    }
}
