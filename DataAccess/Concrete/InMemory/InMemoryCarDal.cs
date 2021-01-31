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
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id=1, BrandId=1, ColorId=1, ModelYear=2020, DailyPrice=200, Description="Minimum 2 yıllık sürücü belgesi."},
                new Car{Id=2, BrandId=1, ColorId=1, ModelYear=2021, DailyPrice=220, Description="Minimum 2 yıllık sürücü belgesi."},
                new Car{Id=3, BrandId=2, ColorId=2, ModelYear=2018, DailyPrice=180, Description="Minimum 2 yıllık sürücü belgesi."},
                new Car{Id=4, BrandId=3, ColorId=3, ModelYear=2019, DailyPrice=170, Description="Minimum 2 yıllık sürücü belgesi."},
                new Car{Id=5, BrandId=4, ColorId=3, ModelYear=2016, DailyPrice=150, Description="Minimum 2 yıllık sürücü belgesi."},
                new Car{Id=6, BrandId=4, ColorId=4, ModelYear=2021, DailyPrice=260, Description="Minimum 2 yıllık sürücü belgesi."},
                new Car{Id=7, BrandId=4, ColorId=4, ModelYear=2021, DailyPrice=300, Description="Minimum 2 yıllık sürücü belgesi."},
                new Car{Id=8, BrandId=5, ColorId=4, ModelYear=2016, DailyPrice=90,  Description="Minimum 2 yıllık sürücü belgesi."},
                new Car{Id=9, BrandId=5, ColorId=1, ModelYear=2015, DailyPrice=90,  Description="Minimum 2 yıllık sürücü belgesi."},
                new Car{Id=10, BrandId=5, ColorId=1, ModelYear=2018, DailyPrice=190,  Description="Minimum 2 yıllık sürücü belgesi."}
            };
        }
       

        public void Add(Car car)
        {
            _cars.Add(car);
        }

       
        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.BrandId == c.BrandId);
            _cars.Remove(carToDelete);
        }

        
        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

       

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.BrandId == car.BrandId);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
