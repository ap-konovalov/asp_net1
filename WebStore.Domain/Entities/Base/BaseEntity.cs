using WebStore.Domain.Entities.Base.Interfaces;

namespace WebStore.Domain.Entities.Base
{
    /// <summary>
    /// сущность
    /// </summary>
    public abstract class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
    }
}