using Core.DataAccess.EntityRepository;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Dto;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<CarDetailDto> GetCarsDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             select new CarDetailDto
                             {
                                 CarBrandName = b.BrandName,
                                 CarModelName = c.Description,
                                 CarModelYear = c.ModelYear,
                                 CarDailyPrice = c.DailyPrice,
                                 ColorName = co.ColorName
                             };
                return result.ToList();
            }
        }
    }
}
