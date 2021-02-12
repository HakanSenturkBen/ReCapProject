using Businness.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using System;

namespace ReCapProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var cars in carManager.GetAll())
            {
                Console.WriteLine(cars.CarName+" "+cars.Description);
            }
        }

        
    }
}
