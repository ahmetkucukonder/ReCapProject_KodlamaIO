using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            UserTest();
            //CarTest();
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + " / " + car.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            var result = userManager.GetAll();

            if (result.Success == true)
            {
                foreach (var user in result.Data)
                {
                    Console.WriteLine(user.FirstName + " " + user.LastName + " / Email: " + user.Email);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
