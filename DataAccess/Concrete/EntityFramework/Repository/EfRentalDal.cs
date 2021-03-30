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
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from rental in context.Rentals
                             join c in context.Cars
                             on rental.CarId equals c.Id

                             join customer in context.Customers
                             on rental.CustomerId equals customer.UserId
                             join brand in context.Brands
                             on c.BrandId equals brand.BrandId
                    
                             select new RentalDetailDto
                             {
                                 RentalID = rental.Id,
                                 CarName = brand.BrandName,
                                 CompanyName = customer.CompanyName,
                                 RentDate = rental.RentDate,
                                 ReturnDate = rental.ReturnDate
                             };
                return result.ToList();

            }
        }
    }

}



