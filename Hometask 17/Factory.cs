using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Factory
    {

    }

    enum CarBrand
    {
        Toyota,
        Kia,
        BWM
    }

    interface ICar
    {
        void TurnOnEngine();
        void TurnOffEngine();
    }

    class Toyota : ICar
    {
        public void TurnOffEngine()
        {
            Console.WriteLine($"{this.GetType().Name} Message: the car engine is OFF");
        }

        public void TurnOnEngine()
        {
            Console.WriteLine($"{this.GetType().Name} Message: the car engine is ON");
        }
    }

    class Kia : ICar
    {
        public void TurnOffEngine()
        {
            Console.WriteLine($"{this.GetType().Name} Message: the car engine is OFF");
        }

        public void TurnOnEngine()
        {
            Console.WriteLine($"{this.GetType().Name} Message: the car engine is ON");
        }
    }

    class BMW : ICar
    {
        public void TurnOffEngine()
        {
            Console.WriteLine($"{this.GetType().Name} Message: the car engine is OFF");
        }

        public void TurnOnEngine()
        {
            Console.WriteLine($"{this.GetType().Name} Message: the car engine is ON");
        }
    }

    interface ICarFactory
    {
        ICar CreateCar(CarBrand brand);
    }

    class CarFactory : ICarFactory
    {
        public ICar CreateCar(CarBrand brand)
        {
            switch (brand)
            {
                case CarBrand.Toyota:
                    return new Toyota();
                case CarBrand.Kia:
                    return new Kia();
                case CarBrand.BWM:
                    return new BMW();
                default: throw new NotImplementedException("There's no such a car brand!");
            };
        }
    }
}
