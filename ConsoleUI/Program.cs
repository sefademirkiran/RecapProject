using Business.Concrete;
using DataAccess.Concrete.EntityFramework.Repository;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            Console.WriteLine("Brad Id'si 1 olan araçlar : \n Id \t Color Name \t Brand Name \t Model Year \t Daily Price \t Descriptions");
            foreach (var car  in carManager.GetAllByBrandId(1))
            {
                Console.WriteLine($"{car.ColorId} \t {colorManager.GetById(car.ColorId).ColorName} ");
            }
            
        }
    }
}
