using CarClass.MyCar;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTest.CarUnitTest
{
    public class Test
    {
        private Car _car;

        public Test()
        {
            _car = new Car(2, 4, "black");
        }

        [Fact]
        public void CarClass_getCarDoor_ReturnInt()
        {
            //variable

            //execute
            var result = _car.getCarDoor();

            //assert
            result.Should().BeInRange(1, 5);

        }

        [Fact]
        public void CarClass_getCarWheels_ReturnInt()
        {
            //variable

            //execute
            var result = _car.getCarWheels();
            //assert

            result.Should().Be(4);

        }

        [Fact]

        public void CarClass_getCarColor_ReturnString()
        {
            //variables
            List<string> colors = new List<string>
            {
                "pink",
                "blue",
                "black",
                "red",
                "white"
            };

            //execute

            var result = _car.getCarColor();

            //assert

            result.Should().BeOneOf(colors);


        }


    }
}
