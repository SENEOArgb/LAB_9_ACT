using ClassMassiv8;
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

namespace ClassMassiv_lab8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private Massiv array;


        private void arrayLengthButton_Click(object sender, RoutedEventArgs e)
        {
            // Получаем размер массива, введенный пользователем
            int length = int.Parse(arrayLengthResultTextBox.Text);

            // Создаем новый экземпляр массива с указанным размером
            array = new Massiv(length);

            // Открываем окно для ввода массива
            ArrayInput arrayInput = new ArrayInput();
            arrayInput.ShowDialog();

            // После закрытия окна копируем введенный массив в TextBox
            arrayInputTextBox.Text = arrayInput.InputArray;
        }

        private void maxValueButton_Click(object sender, RoutedEventArgs e)
        {
            string[] inputArray = arrayInputTextBox.Text.Split(',');
            array = new Massiv(Array.ConvertAll(inputArray, int.Parse));

            int max = array.maxNumberOfMas(Array.ConvertAll(inputArray, int.Parse));
            MessageBox.Show($"Максимальное число в массиве : \n {max}\n");
            
        }

        private void maxValuePartButton_Click(object sender, RoutedEventArgs e)
        {
            string[] inputArray = arrayInputTextBox.Text.Split(',');
            array = new Massiv(Array.ConvertAll(inputArray, int.Parse));

            int startIndex = int.Parse(startIndexTextBox.Text);
            int endIndex = int.Parse(endIndexTextBox.Text);

            var maxpart = array.MaxNumberOfMas(startIndex, endIndex).ToString();
            MessageBox.Show($"Максимальное число в части массива: \n {maxpart}\n");
        }
    }
}
