using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()//ctor ile program çalıştığın sahte bir veri tabanı oluşturdum 
        {
            _cars = new List<Car> { 
                new Car{BrandId=1,ColorId=1,DailyPrice=80000,Id=1,Description="asdf",ModelYear=2012 },
                new Car{BrandId=2,ColorId=2,DailyPrice=95000,Id=2,Description="asdfas",ModelYear=2013 },
                new Car{BrandId=3,ColorId=3,DailyPrice=250000,Id=3,Description="asdccf",ModelYear=2014 },
                new Car{BrandId=3,ColorId=5,DailyPrice=125000,Id=3,Description="asdasf",ModelYear=2015 },
                new Car{BrandId=1,ColorId=4,DailyPrice=230000,Id=4,Description="ascacsadf",ModelYear=2016 },
                new Car{BrandId=2,ColorId=3,DailyPrice=94000,Id=5,Description="ascacsadf",ModelYear=2017 }
            };
        }






        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var result = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(result); 
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByBrandId(int brandId)
        {
            var result = _cars.Where(p => p.BrandId == brandId).ToList();
            return result;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            var CarUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            CarUpdate.BrandId = car.BrandId;
            CarUpdate.ColorId = car.ColorId;
            CarUpdate.DailyPrice = car.DailyPrice;
            CarUpdate.Description = car.Description;
            CarUpdate.ModelYear = car.ModelYear;



        }
    }
}
