using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        //bir iş sınıfı başka sınıfları newlemez bu yüzeden
        ICarDal _CarDal;

        public CarManager(ICarDal CarDal)
        {
            _CarDal = CarDal;
        }

        public List<Car> GetAll()
        {
            //iş kodları
            // veri erişimi çağır
            return _CarDal.GetAll();
        }
    }
}
