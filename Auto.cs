using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_Taxi
{
    class Auto
    {
        string number;
        Enums.Brand brand;
        Enums.Model model;
        Driver[] drivers;
        Enums.AutoType autoType;
        Enums.AutoColor autoColor;
        Enums.AutoCondition autoCondition;
        float price;

        public string Number { get => number; set => number = value; }
        public float Price { get => price; set => price = value; }
        internal Enums.Brand Brand { get => brand; set => brand = value; }
        internal Enums.Model Model { get => model; set => model = value; }
        internal Driver[] Drivers { get => drivers; set => drivers = value; }
        internal Enums.AutoType AutoType { get => autoType; set => autoType = value; }
        internal Enums.AutoColor AutoColor { get => autoColor; set => autoColor = value; }
        internal Enums.AutoCondition AutoCondition { get => autoCondition; set => autoCondition = value; }

        public Auto(string number, Enums.Brand brand, Enums.Model model, Driver[] drivers, float price)
        {
            Number = number;
            Brand = brand;
            Model = model;
            Drivers = drivers;
            Price = price;
        }

        public Auto(string number, Enums.Brand brand, Enums.Model model, Driver[] drivers, float price, Enums.AutoColor autoColor) : this(number, brand, model, drivers, price)
        {
            AutoColor = autoColor;
        }

        public Auto(string number, Enums.Brand brand, Enums.Model model, Driver[] drivers, float price, Enums.AutoColor autoColor, Enums.AutoType autoType) : this(number, brand, model, drivers, price, autoColor)
        {
            AutoType = autoType;
        }

        public Auto(string number, Enums.Brand brand, Enums.Model model, Driver[] drivers, float price, Enums.AutoColor autoColor, Enums.AutoType autoType, Enums.AutoCondition autoCondition) : this(number, brand, model, drivers, price, autoColor, autoType)
        {
            AutoCondition = autoCondition;
        }

        public bool FindByNum(string num)
        {
            return (Number.Contains(num));
        }

        public override string ToString()
        {
            string driverList = "", result = $"{Brand} {Model}, {Number}";
            result += ((int)AutoColor != 0) ? ", " + AutoColor.ToString() : "";
            result += ((int)AutoType != 0) ? ", " + AutoType.ToString() : "";

            result += "\n";
            foreach (Driver driver in Drivers)
            {
                driverList += (driverList != "" ? ", " : "");
                driverList += driver.Name;
            }

            result += $"Водител{(Drivers.Length > 1 ? "и" : "ь")}: " + driverList;
            result += $"\nPrice: ${Math.Round(Price, 2)}";
            return result;
        }
    }
}
