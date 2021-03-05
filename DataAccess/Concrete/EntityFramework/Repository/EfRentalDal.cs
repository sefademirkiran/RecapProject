using Core.DataAccess.EntitiyFramework;
using DataAccess.Abstract;

using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataAccess.Concrete.EntityFramework.Context;

namespace DataAccess.Concrete.EntityFramework.Repository
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        //    public List<RentalDetailDto> GetRentalDetails()
        //    {
        //        using (RentACarContext context = new RentACarContext())
        //        {
        //            var result = from rental in context.Rental
        //                         join car in context.Cars on rental.CarId equals car.Id
        //                         join customer in context.Customers on rental.UserId equals customer.UserId
        //                         join user in context.Users on customer.Id equals user.Id
        //                         join brand in context.Brands on car.BrandId equals brand.BrandId
        //                         join color in context.Colors on car.ColorId equals color.ColorId
        //                         select new RentalDetailDto
        //                         {

        //                             RentalId = rental.RentalId,
        //                             CarId = car.Id,
        //                             CustomerId = customer.CustomerId,
        //                             UserId = user.Id,
        //                             CompanyName = customer.CompanyName,
        //                             BrandName = brand.BrandName,
        //                             ColorName = color.ColorName,
        //                             FirstName = user.FirstName,
        //                             LastName = user.LastName,
        //                             //RentDate = rental.RentDate,
        //                             //ReturnDate = rental.ReturnDate,
        //                             ModelYear = car.ModelYear,
        //                             DailyPrice = car.DailyPrice,
        //                             Description = car.Descriptions,

        //                         };
        //            return result.ToList();

        //        }
        //    }
        //}
        public List<RentalDetailDto> GetRentalDetails()
        {
            throw new NotImplementedException();
        }
    }
}
    

