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
using System.Windows.Shapes;

namespace ClassMassiv_lab8
{
    /// <summary>
    /// Логика взаимодействия для ArrayInput.xaml
    /// </summary>
    public partial class ArrayInput : Window
    {
        public ArrayInput()
        {
            InitializeComponent();
        }

        public string InputArray { get; private set; }


        private void OK_Click(object sender, RoutedEventArgs e)
        {
            InputArray = arrayInputTextBox.Text;
            Close();
        }
    }
}
