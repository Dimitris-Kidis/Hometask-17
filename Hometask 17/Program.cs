using System;



// 1. Singleton Implementation
// 2. Simple Factory Implementation



namespace App
{
    class Program
    {
        public static void Main(string[] args)
        {
            // 1.
            var singleton = Singleton.Instance;


            // 2.
            ICarFactory simpleCarFactory = new CarFactory();
            ICar kia = simpleCarFactory.CreateCar(CarBrand.Kia);
            kia.TurnOnEngine();

        }
    }
}