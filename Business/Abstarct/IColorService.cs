using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;



namespace Business.Abstarct
{
    public interface IColorService
    {
        IResult Add(Color color);
        IDataResult<Color> GetById(int id);
        IDataResult<List<Color>> GetAll();
    }
}
