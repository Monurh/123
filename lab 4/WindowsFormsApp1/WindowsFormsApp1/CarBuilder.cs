using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class CarBuilder
    {
        private Car _car;

        public CarBuilder()
        {
            _car = new Car();
        }

        public void SetColor(string color)
        {
            _car.Color = color;
        }

        public void SetEngine(string engine)
        {
            _car.Engine = engine;
        }

        public void SetNumWheels(int numWheels)
        {
            _car.NumWheels = numWheels;
        }

        public Car GetCar()
        {
            return _car;
        }
    }
}
