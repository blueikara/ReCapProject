using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstarct
{
    public interface IBrandService
    {
        IResult Add(Brand brand);
        IDataResult<Brand> GetById(int id);
        IDataResult<List<Brand>> GetAll();
    }
}
