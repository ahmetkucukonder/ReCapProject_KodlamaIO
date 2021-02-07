using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("--------------------- Get All Cars ---------------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName);
            }
            
            Console.WriteLine("--------------------- Get Car Details ---------------------");
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("Car Name:" + car.CarName + ", Brand Name:" + car.BrandName+ ", Description:" + car.Description + " Color:" + car.ColorName);
            }
        }
    }
}
