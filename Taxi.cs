using System;

namespace Lesson7_Taxi
{
    class Taxi : Car
    {
        bool isDeleted = false;

        public bool IsDeleted { get => isDeleted; set => isDeleted = value; }

        public Taxi(string number, Enums.Brand brand, Enums.Model model, Driver[] drivers, float price) : base(number, brand, model, drivers, price) {

        }
        
        public Taxi(Car car)
        {
            this.Number = car.Number;
            this.Brand = car.Brand;
            this.Model = car.Model;

            this.Drivers = new Driver[car.Drivers.Length];
            for (int i = 0; i < car.Drivers.Length; i++)
            {
                this.Drivers[i] = new Driver(car.Drivers[i]);
            }

            this.Price = car.Price;
            this.CarColor = car.CarColor;
            this.CarType = car.CarType;
            this.CarCondition = car.CarCondition;
        }

    }
}
