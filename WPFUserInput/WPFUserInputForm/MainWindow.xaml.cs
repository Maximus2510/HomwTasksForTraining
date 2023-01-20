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
using ClassLibForFramework;

namespace WPFUserInputForm
{
    public partial class MainWindow : Window
    {
        public string name = "";
        DateTime currentTime = DateTime.Now;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickButton_Click(object sender, RoutedEventArgs e)
        {
            name = NameEnterTextBox.Text;

            string resultStr = Concatenation.Concatenate($"{currentTime.ToString()}: ", "Hello, ", $"{name}");

            MessageBox.Show($"Hello, {name}");
            MessageBox.Show(resultStr);
        }
    }
}
