using MyLibrary.Entities.Abstract;

namespace MyLibrary.Entities.Concrete
{
    public class Publisher:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
