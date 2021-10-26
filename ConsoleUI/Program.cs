using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            EfRentalManager rentalManager = new EfRentalManager(new EfRentalDal());

            var result = rentalManager.GetCarDetail();
            foreach (var detail in result.Data)
            {
                Console.WriteLine("{0} / {1} / {2}",detail.CarName,detail.RentId,detail.CarId);
            }
            Console.ReadLine();
        }
    }
}
