﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;
using System.Collections.Generic;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car,ReCapContext>,ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapContext context =new ReCapContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join a in context.Colors
                             on c.ColorId equals a.ColorId
                             select new CarDetailDto {
                               BrandId = c.BrandId, BrandName = b.BrandName, CarId = c.CarId, CarName = c.CarName,
                               ColorId=c.ColorId, DailyPrice=c.DailyPrice, Description=c.Description,
                               ModelYear=c.ModelYear, ColorName=a.ColorName
                             };
                return result.ToList();
            }
        }
    }
}
