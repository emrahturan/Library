using System.Security.AccessControl;
using MyLibrary.Entities.Abstract;

namespace MyLibrary.Entities.Concrete
{
    public class Book:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ISBN { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
        public int PublisherId { get; set; }
        public int PublishedYear { get; set; }
    }
}
