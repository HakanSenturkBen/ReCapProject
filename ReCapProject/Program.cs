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
            CarManager carManager = new CarManager(new EFCarDal());

            foreach (var cars in carManager.GetAll())
            {
                Console.WriteLine(cars.CarName+" "+cars.Description);
            }
        }

        
    }
}
