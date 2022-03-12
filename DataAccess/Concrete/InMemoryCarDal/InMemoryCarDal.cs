using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemoryCarDal
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=101,ColorId=202,DailyPrice=150,ModelYear=2000,Description="4x4 araba"},
                new Car{CarId=2,BrandId=102,ColorId=202,DailyPrice=100,ModelYear=2020,Description="Limuziç araba"},
                new Car{CarId=3,BrandId=102,ColorId=203,DailyPrice=140,ModelYear=2021,Description="Ağır Vasıta"},
                new Car{CarId=4,BrandId=103,ColorId=204,DailyPrice=170,ModelYear=2022,Description="Güzel araba"},
                new Car{CarId=5,BrandId=101,ColorId=201,DailyPrice=190,ModelYear=2001,Description="Hızlı araba"},

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public int GetById(int id)
        {
            Car result = _cars.SingleOrDefault(c => c.CarId == id);
            return result.CarId;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
   
        }
    }
}
