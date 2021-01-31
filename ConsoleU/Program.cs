using Business.Concrete;
using DataAccess.Concrate.InMemory;
using System;

namespace ConsoleU
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId);
            }
        }
    }
}
