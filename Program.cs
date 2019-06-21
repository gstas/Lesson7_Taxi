using System;

namespace Lesson7_Taxi
{
    class Program
    {
        /*
        Реализовать класс Таксопарк, как динамический массив объектов класса Такси 
        с реализацией всевозможных проверок всех полей всех классов.

        Создать консольное приложение, позволяющее заполнить 
        и получить всевозможную статистику по автопарку.

        Ниже приведён перечень обязательных (полей) и [методов] для всех классов, 
        участвующих в проекте.

        Таксопарк (массив автомобилей) 
        [добавить авто с номером, удалить авто с номером, отредактировать авто с номером,
        очистить таксопарк, заполнить таксопарк, setter и getter для каждого поля, 
        несколько видов конструкторов, статистические методы (например, поиск авто по номеру)]

        Автомобиль (регистрационный номер, марка, модель, водители (массив), тип, 
        цвет, состояние, цена) [setter и getter для каждого поля, 
        несколько видов конструкторов, статистические методы]

        Водитель (ФИО, дом.адрес,  телефон, дата рождения) 
        [setter и getter для каждого поля, несколько видов конструкторов, статистические методы] 
        */

        static void Main(string[] args)
        {
            Driver driver1 = new Driver("Иванов Иван", "0970000001");
            Driver driver2 = new Driver("Петров Петр", "0970000002");
            Driver driver3 = new Driver("Сидоров Сидр", "0970000003", "ул. Пушкина, 1", new DateTime(2001, 3, 15));

            Driver driver4 = new Driver(driver3);
            driver4.Name = "Федоров Федр";
            driver4.Birthday = new DateTime(1990, 5, 23);


            Auto auto1 = new Auto(
                "BH0001HH", 
                Enums.Brand.Toyota, 
                Enums.Model.Camry, 
                new Driver[] { driver1 },
                50f
            );

            Auto auto2 = new Auto(
                "BH0002HH",
                Enums.Brand.Kia,
                Enums.Model.Sportage,
                new Driver[] { driver1, driver4 },
                75.5f,
                Enums.AutoColor.Red,
                Enums.AutoType.SUV
            );

            Console.WriteLine(auto1);
            Console.WriteLine(auto2);

            

        }
    }
}
