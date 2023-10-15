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
using lb1.Beverage;
namespace lb1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>


    //        <Grid.ColumnDefinitions>
    //    <ColumnDefinition/>
    //    <ColumnDefinition/>
    //    <ColumnDefinition/>
    //</Grid.ColumnDefinitions>
    //<Grid.RowDefinitions>
    //    <RowDefinition/>
    //    <RowDefinition/>
    //    <RowDefinition/>
    //</Grid.RowDefinitions>
    //<Button Grid.Column="0" Grid.Row= "0" Content= "OK" Click= "Button_Click" />
    public class Order
    {
        public Order() { }
        public double pushingMoney = 0.0;
        private Beverage.Beverage _beverage;
        private Beverage.Beverage order;
        public List<string> services = new List<string>();

        public void SetBeverage(Beverage.Beverage beverage)
        {
            _beverage = beverage;
        }
        private Beverage.Beverage getOrder()
        {
            order = _beverage;


            if (services.Contains("MilkCB"))
            {
                order = new MilkDecorator(order);
            }
            if (services.Contains("SugarCB"))
            {
                order = new SugarDecorator(order);
            }

            return order;
        }

        public double getCost()
        {

            return getOrder().GetCost();
        }
        public string getDescr()
        {
            return getOrder().getDescrition();
        }
    }
    public partial class MainWindow : Window
    {

        Order order;

        public MainWindow()
        {
            InitializeComponent();
            order = new Order();
            order.SetBeverage(new Americano());
            SetBeverageCost();
        }

        private void SetBeverageCost()
        {
            BeverageCost.Content = $"Цена напитка: {order.getCost()}";

        }
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Проверяем, является ли вводимый текст числом
            if (!IsNumber(e.Text))
            {
                e.Handled = true;  // Отменяем ввод
            }
        }

        // Функция для проверки, является ли строка числом
        private bool IsNumber(string text)
        {
            return int.TryParse(text, out _);
        }


        private void RadioButton_ChekedChange(object sender, RoutedEventArgs e)
        {
            PushMoney.IsEnabled = true;
            var rb = (RadioButton)sender;
            string imagePath = "Img/";
            if (MainOrder == null) return;
            if (rb.Name == "AmericanoRB")
            {
                imagePath += "americano.jpg";
                order.SetBeverage(new Americano());
                SetBeverageCost();
            }
            else if (rb.Name == "CappuccinoRB")
            {
                imagePath += "cap.jpg";
                order.SetBeverage(new Cappuccino());
                SetBeverageCost();
            }
            else if (rb.Name == "EspressoRB")
            {
                imagePath += "Espresso.jpg";
                order.SetBeverage(new Espresso());
                SetBeverageCost();
            }
            else if (rb.Name == "CocoaRB")
            {
                imagePath += "Cacao.jpg";
                order.SetBeverage(new Cocoa());
                SetBeverageCost();

            }
            MainOrder.Source = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
        }

        private void CheckBox_ChekedChange(object sender, RoutedEventArgs e)
        {
            var cb = (CheckBox)sender;
            string imagePath = "Img/";

            if (cb.Name == "SugarCB")
            {

                if (cb.IsChecked == false)
                {
                    imagePath = "";
                    order.services.Remove(cb.Name);
                    SetBeverageCost();
                }
                else
                {
                    imagePath += "Sugar.jpg";
                    order.services.Add(cb.Name);
                    SetBeverageCost();
                }
                SugarJPG.Source = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
            }
            else if (cb.Name == "MilkCB")
            {
                if (cb.IsChecked == false)
                {
                    imagePath = "";
                    order.services.Remove(cb.Name);
                    SetBeverageCost();
                }
                else
                {
                    imagePath += "Milk.jpg";
                    order.services.Add(cb.Name);
                    SetBeverageCost();
                }
                MilkJPG.Source = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
            }


        }

        private void pay(object sender, RoutedEventArgs e)
        {
            if(InputCost.Text == "" || double.Parse(InputCost.Text) <= 0)
            {
                MessageBox.Show("Некоректный ввод");
                return;
            }
            _enableBtn(false);
            order.pushingMoney += double.Parse(InputCost.Text);
            OutputCost.Content = $"Внесенная сумма: {order.pushingMoney}";
            if (order.getCost() < order.pushingMoney)
            {
                PushMoney.IsEnabled = false;
                Change.Content = $"Сдача: {order.pushingMoney - order.getCost()}";
            }
        }

        private void _enableBtn(bool e)
        {
            AmericanoRB.IsEnabled = e;
            CocoaRB.IsEnabled = e;
            CappuccinoRB.IsEnabled = e;
            EspressoRB.IsEnabled = e;
            SugarCB.IsEnabled = e;
            MilkCB.IsEnabled = e;


        }

        private void ok(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(order.getDescr(), "Ваш заказ");
            OutputCost.Content = "Внесенная сумма: 0.0";
            Change.Content = "Сдача: 0.0";
            BeverageCost.Content = "Цена напитка: 0.0";
            _enableBtn(true);
            PushMoney.IsEnabled = true;
            InputCost.Text = "";
            MilkCB.IsChecked = false;
            SugarCB.IsChecked = false;
        }
    }
}
