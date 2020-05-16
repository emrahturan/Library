﻿using MyLibrary.Core.Entities;

namespace MyLibrary.Entities.Concrete
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
