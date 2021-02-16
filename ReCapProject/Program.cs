using Businness.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameWork;
using DataAccess.Concrete.InMemory;
using System;

namespace ReCapProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EFCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success)
            {
                foreach (var cars in result.Data)
                {
                    Console.WriteLine("{0,20} {1,-20}", cars.BrandName, cars.CarName);
                }
            }
            
        }

    }
}
