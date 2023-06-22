using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass.MyCar
{
    public class Car
    {

        private int carDoor;
        private int carWheels;
        private string carColor;

        public Car(int carDoor, int carWheels,string carColor)
        {
            this.carDoor = carDoor;
            this.carWheels = carWheels;
            this.carColor = carColor;
        }

        public int getCarDoor()
        {
            return this.carDoor;
        }

        public int getCarWheels()
        {
            return this.carWheels;
        }
        
        public string getCarColor()
        {
            return this.carColor;
        }





    }
}
