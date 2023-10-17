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

namespace lb1._2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void ContinueButton_Click(object sender, RoutedEventArgs e)
        {
            // Получите введенное количество этажей
            int numberOfFloors = int.Parse(floorTextBox.Text);
            if (numberOfFloors > 0)
            {
                // Создайте вторую форму и передайте количество этажей
                SecondWindow secondWindow = new SecondWindow(numberOfFloors);

                // Откройте вторую форму
                secondWindow.Show();

                // Закройте текущую форму
                Close();
            }
            else
            {
                // Обработка некорректного ввода
                MessageBox.Show("Пожалуйста, введите корректное количество этажей.");
            }
        }
    }
}
