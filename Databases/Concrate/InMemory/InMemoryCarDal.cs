using DataAccess.Absract;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrate.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car { CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 15000, Description = "SecondHand", ModelYear = 2010 },
                new Car { CarId = 2, BrandId = 1, ColorId = 2, DailyPrice = 25000, Description = "SecondHand", ModelYear = 2009 },
                new Car { CarId = 3, BrandId = 2, ColorId = 2, DailyPrice = 35000, Description = "SecondHand", ModelYear = 2005 },
                new Car { CarId = 4, BrandId = 3, ColorId = 2, DailyPrice = 55000, Description = "SecondHand", ModelYear = 2011 },
                new Car { CarId = 5, BrandId = 3, ColorId = 3, DailyPrice = 65000, Description = "SecondHand", ModelYear = 2015 },
                new Car { CarId = 6, BrandId = 4, ColorId = 3, DailyPrice = 125000, Description = "SecondHand", ModelYear = 2020 },
                new Car { CarId = 7, BrandId = 5, ColorId = 3, DailyPrice = 12000, Description = "SecondHand", ModelYear = 2019 },
                new Car { CarId = 8, BrandId = 5, ColorId = 4, DailyPrice = 14000, Description = "SecondHand", ModelYear = 2014 },
                new Car { CarId = 9, BrandId = 1, ColorId = 4, DailyPrice = 12500, Description = "SecondHand", ModelYear = 2002 },
                new Car { CarId = 10, BrandId = 5, ColorId = 4, DailyPrice = 15800, Description = "SecondHand", ModelYear = 2008 }
            };



        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(p => p.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

         
        }
    }
}
