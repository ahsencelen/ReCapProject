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
            foreach (var c in carManager.GetAll()) 
            {
                Console.WriteLine("Brand Id \t" + "Color Id \t" + "Daily Price \t" + "Model Year \t" + "Description");
                Console.WriteLine(c.BrandId + "\t\t" + c.ColorId + "\t\t" + c.DailyPrice + "\t\t" + c.ModelYear + "\t\t" + c.Description);
            }
        }
    }
}
