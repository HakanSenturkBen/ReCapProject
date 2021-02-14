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

            foreach (var cars in carManager.GetCarDetails())
            {
                Console.WriteLine("{ 0,15} { 1,-15 }", cars.CarName,cars.BrandName);
            }
        }

    }
}
