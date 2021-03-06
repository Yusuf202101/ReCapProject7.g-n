using Business.Concrete;
using DataAccess.Concrete.InMemoryCarDal;
using System;

namespace Console_UI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }
        }
    }
}
