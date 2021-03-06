using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface ICarDal
    {
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        int GetById(int id);
        List<Car> GetAll();

    }
}
