﻿using Core.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {

        IDataResult<List<Color>> GetAll();
        IDataResult<List<Color>> GetById(int colorId);

        IResult Add(Color color);
        IResult Update(Color color);
        IResult Delete(Color color);

    }
}
