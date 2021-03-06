﻿using MyLibrary.Core.DataAccess;
using MyLibrary.Entities.Concrete;

namespace MyLibrary.DataAccess.Abstract
{
    public interface IAuthorDal : IEntityRepository<Author>
    {
    }
}
