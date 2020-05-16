using System.Linq;
using MyLibrary.Core.Entities;

namespace MyLibrary.Core.DataAccess
{
    public interface IQueryableRepository<T> where T : class, IEntity, new()
    {
        IQueryable<T> Table { get; }
    }
}
