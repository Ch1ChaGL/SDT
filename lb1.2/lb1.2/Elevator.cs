using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lb1._2
{
    public enum Move
    {
        MoveTop,
        MoveBottom,
    }
    public enum Operation
    {
        Open,
        Close
    }
    internal class Elevator
    {

        private House _house;
        private int _currentFloor = 1;
        private int _passenger = 0;
        private bool _isOpen = false;

        public Elevator(House house)
        {
            _house = house;
        }

        public void AddPassenger(int countPassanger)
        {
            if (countPassanger <= 0) throw new Exception("Количество пассажиров не может быть меньше или равно 0");

            _passenger = countPassanger;
        }

        public void MoveElevator(Move moveDirection)
        {
            if (_isOpen) throw new Exception("Двигаться с открытми дверьми нельзя");
            if (moveDirection == Move.MoveTop)
            {
                if (_currentFloor == _house.getCountFloor())
                {
                    throw new Exception("Движение вверх невозможно, достигнут последний этаж");
                }
                else
                {
                    _currentFloor++;
                    return;
                }
            }
            else if (moveDirection == Move.MoveBottom)
            {
                if (_currentFloor == 0)
                {
                    throw new Exception("Движение вниз невозможно, достигнут первый этаж");
                }
                else
                {
                    _currentFloor--;
                    return;
                }
            }
            throw new Exception("Неверно выбрано направление");
        }

        public void OperationElevator(Operation operation)
        {
            if (_isOpen && operation == Operation.Open) throw new Exception("Двери уже открыты");
            if (!_isOpen && operation == Operation.Close) throw new Exception("Двери уже закрыты");

            if (Operation.Open == operation)
            {
                _isOpen = true;
                return;
            }
            else if (Operation.Close == operation)
            {
                _isOpen = false;
                return;
            }
            throw new Exception("Выбрано неверная операция");
        }

        public void CallElevator(int floor)
        {
            _currentFloor = floor;
        }
        public int getPassenger()
        {
            return _passenger;
        }
        public int GetCurrentFloor()
        {
            return _currentFloor;
        }

        public bool GetIsOpen()
        {
            return _isOpen;
        }

        public void SetIsOpen(bool isOpen)
        {
            _isOpen = isOpen;
        }
    }
}
