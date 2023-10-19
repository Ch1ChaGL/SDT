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
using System.Windows.Threading;

namespace lb1._2
{
    /// <summary>
    /// Логика взаимодействия для SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        private DispatcherTimer timerMoveElevator;
        private DispatcherTimer timerOpenDoor;
        private DispatcherTimer timerState;
        DispatcherTimer timerCloseDoor;
        private int destinationFloor = 1;
        Elevator elevator;
        House house;
        public SecondWindow(int countFloor)
        {
            InitializeComponent();
            addButtonsFloor(countFloor);
            house = new House(countFloor);
            elevator = new Elevator(house);

            timerMoveElevator = new DispatcherTimer();
            timerMoveElevator.Interval = TimeSpan.FromSeconds(1);
            timerMoveElevator.Tick += Timer_TickElevatorMove;

            timerOpenDoor = new DispatcherTimer();
            timerOpenDoor.Interval = TimeSpan.FromSeconds(1);
            timerOpenDoor.Tick += Timer_OpenDoor;

            timerState = new DispatcherTimer();
            timerState.Interval = TimeSpan.FromSeconds(1); 
            timerState.Tick += Timer_State;
            timerState.Start();
        }

        public void addButtonsFloor(int countFloor)
        {
            for (int i = countFloor; i > 0; i--)
            {
                Button btn = new Button();
                btn.Content = i.ToString();
                btn.Name = ($"floor_{i}").ToString();
                btn.Width = 50;
                btn.Height = 50;
                btn.Click += pressBtn;
                btn.Margin = new Thickness(0,0,0,10);

                if (i % 2 == 0)
                {
                    leftColumn.Children.Add(btn);
                }
                else
                {
                    rightColumn.Children.Add(btn);
                }
            }
        }

        public void pressBtn(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            destinationFloor = int.Parse(btn.Content.ToString());
            timerMoveElevator.Start();
        }

        private void callElevatorToFloor(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(calledFloor.Text.ToString());
           

            if(a > house.getCountFloor())
            {
                MessageBox.Show("Движение невозможно");
                return;
            }
            destinationFloor = int.Parse(calledFloor.Text.ToString());
            timerMoveElevator.Start();
        }
        private void enableBtn(bool en)
        {
            foreach (Button btn in rightColumn.Children)
            {
                btn.IsEnabled = en;
            }
            foreach (Button btn in leftColumn.Children)
            {
                btn.IsEnabled = en;
            }
            callElevator.IsEnabled = en;
        }
        private void Timer_TickElevatorMove(object sender, EventArgs e)
        {
            try
            {
                if (destinationFloor == elevator.GetCurrentFloor())
                {
                    elevator.OperationElevator(Operation.Open);

                    timerMoveElevator.Stop();
                    timerOpenDoor.Start();
                    enableBtn(true);
                }
                if (destinationFloor > elevator.GetCurrentFloor())
                {
                    elevator.MoveElevator(Move.MoveTop);
                    enableBtn(false);
                }
                if (destinationFloor < elevator.GetCurrentFloor())
                {
                    elevator.MoveElevator(Move.MoveBottom);
                    enableBtn(false);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                timerMoveElevator.Stop();
                timerOpenDoor.Start();
            }

        }

        private void Timer_OpenDoor(object sender, EventArgs e)
        {
            elevator.SetIsOpen(!elevator.GetIsOpen());
            timerOpenDoor.Stop();

            timerCloseDoor = new DispatcherTimer();
            timerCloseDoor.Interval = TimeSpan.FromSeconds(1);
            timerCloseDoor.Tick += Timer_CloseDoor;
        }

        private void Timer_CloseDoor(object sender, EventArgs e)
        {
            elevator.SetIsOpen(!elevator.GetIsOpen());
            timerCloseDoor.Stop();

        }

        private void Timer_State(object sender, EventArgs e)
        {

            if (destinationFloor == elevator.GetCurrentFloor())
            {
                State.Content = $"Лифт прибыл на этаж {elevator.GetCurrentFloor()}";
                StateDoor.Content = $"Двери {(elevator.GetIsOpen() == true ? ("Открыты") : ("Закрыты"))}";

            }
            if (destinationFloor > elevator.GetCurrentFloor())
            {
                State.Content = $"Лифт движется вверх, текущий этаж {elevator.GetCurrentFloor()}";
                StateDoor.Content = $"Двери {(elevator.GetIsOpen() == true ? ("Открыты") : ("Закрыты"))}";
            }
            if (destinationFloor < elevator.GetCurrentFloor())
            {
                State.Content = $"Лифт движется вниз, текущий этаж {elevator.GetCurrentFloor()}";
                StateDoor.Content = $"Двери {(elevator.GetIsOpen() == true ? ("Открыты") : ("Закрыты"))}";
            }
        }
    }
}
