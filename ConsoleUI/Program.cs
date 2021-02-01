using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new InMemoryCarDal() );
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Car Id:"+ car.Id + " - " + "Color Id:"+ car.ColorId +" - "+ "Model Year:"+ " - " + car.ModelYear + " - " + "Description:"  +car.Description);
            }
           
            
        }
    }
}
