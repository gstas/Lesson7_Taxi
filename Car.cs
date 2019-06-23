using System;

namespace Lesson7_Taxi
{
    class Car
    {
        string number;
        Enums.Brand brand;
        Enums.Model model;
        Driver[] drivers;
        Enums.CarType carType;
        Enums.CarColor carColor;
        Enums.CarCondition carCondition;
        float price;

        public string Number { get => number; set => number = value; }
        public float Price { get => price; set => price = value; }
        internal Enums.Brand Brand { get => brand; set => brand = value; }
        internal Enums.Model Model { get => model; set => model = value; }
        internal Driver[] Drivers { get => drivers; set => drivers = value; }
        internal Enums.CarType CarType { get => carType; set => carType = value; }
        internal Enums.CarColor CarColor { get => carColor; set => carColor = value; }
        internal Enums.CarCondition CarCondition { get => carCondition; set => carCondition = value; }

        public Car(string number, Enums.Brand brand, Enums.Model model, Driver[] drivers, float price)
        {
            Number = number;
            Brand = brand;
            Model = model;
            Drivers = drivers;
            Price = price;
        }

        public Car() { }

        public Car(string number, Enums.Brand brand, Enums.Model model, Driver[] drivers, float price, Enums.CarColor carColor) : this(number, brand, model, drivers, price)
        {
            CarColor = carColor;
        }

        public Car(string number, Enums.Brand brand, Enums.Model model, Driver[] drivers, float price, Enums.CarColor carColor, Enums.CarType carType) : this(number, brand, model, drivers, price, carColor)
        {
            CarType = carType;
        }

        public Car(string number, Enums.Brand brand, Enums.Model model, Driver[] drivers, float price, Enums.CarColor carColor, Enums.CarType carType, Enums.CarCondition carCondition) : this(number, brand, model, drivers, price, carColor, carType)
        {
            CarCondition = carCondition;
        }

        public bool FindByNum(string num)
        {
            return (Number.ToUpper().Contains(num.ToUpper()));
        }

        public override string ToString()
        {
            string driverList = "", result = $"{Brand} {Model}, {Number}";
            result += ((int)CarColor != 0) ? ", " + CarColor.ToString() : "";
            result += ((int)CarType != 0) ? ", " + CarType.ToString() : "";
                    

            result += "\n";
            foreach (Driver driver in Drivers)
            {
                //driverList += (driverList != "" ? ", " : "");
                //driverList += driver.Name;

                driverList += driver+"\n";
            }

            result += $"----------\nВодител{(Drivers.Length > 1 ? "и" : "ь")}:\n" + driverList+ "----------\n";
            result += $"Price: ${Math.Round(Price, 2)}";
            return result;
        }
    }
}
