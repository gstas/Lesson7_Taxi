using System;

namespace Lesson7_Taxi
{
    class TaxiPark
    {
        Taxi[] taxis;

        internal Taxi[] Taxis { get => taxis; set => taxis = value; }

        public TaxiPark()
        {
            Taxis = new Taxi[0];
        }

        public TaxiPark(Car[] cars)
        {
            Taxis = new Taxi[cars.Length];
            for (int i = 0; i < cars.Length; i++)
            {
                Taxis[i] = new Taxi(cars[i]);
            }
        }

        /*
         Таксопарк (массив автомобилей) 
        [добавить авто с номером,
        удалить авто с номером, 
        отредактировать авто с номером,
        очистить таксопарк, 
        заполнить таксопарк, 
        
        setter и getter для каждого поля, 
        несколько видов конструкторов, статистические методы (например, поиск авто по номеру)]
         */

        public void AddCar(Car car)
        {
            Array.Resize(ref taxis, Taxis.Length + 1);
            Taxis[Taxis.Length - 1] = new Taxi(car);
        }

        public void RemoveByNum(string num)
        {
            foreach (Taxi taxi in Taxis)
                if (taxi.FindByNum(num) && !taxi.IsDeleted)
                    taxi.IsDeleted = true;
        }

        public void Truncate()
        {
            foreach (Taxi taxi in Taxis)
                if (!taxi.IsDeleted)
                    taxi.IsDeleted = true;
        }

        public Taxi[] FindByNum(string num)
        {
            Taxi[] temp = new Taxi[0];
            foreach (Taxi taxi in Taxis)
                if (taxi.FindByNum(num) && !taxi.IsDeleted)
                {
                    Array.Resize(ref temp, temp.Length + 1);
                    temp[temp.Length - 1] = new Taxi(taxi);
                }
            return temp;
        }

        public Driver[] FindDriverByName (string name)
        {
            Driver[] temp = new Driver[0];
           
            foreach (Taxi taxi in Taxis)
                if (!taxi.IsDeleted)
                    foreach (Driver driver in taxi.Drivers)
                       if(driver.FindByName(name)) {
                            Array.Resize(ref temp, temp.Length + 1);
                            temp[temp.Length - 1] = new Driver(driver);
                       }
            return temp;
        }

    }
}
