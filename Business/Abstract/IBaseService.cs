﻿using Core.Utilities.Results;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IBaseService<T>
    {
        IDataResult<List<T>> GetAll();
        IDataResult<T> GetById(int id);
        IResult Add(T entity);
        IResult Update(T entity);
        IResult Delete(T entity);
    }
}
