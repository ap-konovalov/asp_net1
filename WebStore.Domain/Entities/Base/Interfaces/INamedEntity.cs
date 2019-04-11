namespace WebStore.Domain.Entities.Base.Interfaces
{
    /// <summary>
    /// Именованная сущность
    /// </summary>
    public interface INamedEntity : IBaseEntity
    {
        string Name { get; set; }       
    }
}