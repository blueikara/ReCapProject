using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("     Araba Bilgileri    ");
                Console.WriteLine("Araba ID: " + car.CarId);
                Console.WriteLine("Araba Markası ID: " + car.BrandId);
                Console.WriteLine("Araba Rengi ID: " + car.ColorId);
                Console.WriteLine("Araba Ücreti: " + car.DailyPrice);
                Console.WriteLine("Araba Model Yılı: " + car.ModelYear);
                Console.WriteLine("Araba Açıklaması: " + car.Description);


                
            }

            
        }
    }
}       
    

