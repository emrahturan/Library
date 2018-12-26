using MyLibrary.Entities.Abstract;

namespace MyLibrary.Entities.Concrete
{
    public class Author:IEntity
    {
        public int Id { get; set; }
        public string FullName { get; set; }
    }
}
