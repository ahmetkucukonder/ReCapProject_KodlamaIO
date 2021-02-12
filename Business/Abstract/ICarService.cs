using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICarService:IBaseService<Car>
    {
        IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max);
        IDataResult<List<Car>> GetAllByBrandId(int id);
        IDataResult<List<CarDetailDto>> GetCarDetails();
    }
}
