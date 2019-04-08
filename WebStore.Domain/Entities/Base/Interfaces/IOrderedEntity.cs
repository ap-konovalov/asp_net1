namespace WebStore.Domain.Entities.Base.Interfaces
{
    /// Упорядочиваемая сущность    
    public interface IOrderedEntity
    {
        int Order { get; set; }
    }
}