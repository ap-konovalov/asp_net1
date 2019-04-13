using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WebStore.Domain.Entities.Base;
using WebStore.Domain.Entities.Base.Interfaces;

namespace WebStore.Domain.Entities
{
    /// <summary>
    /// Бренад
    /// </summary>
    public class Brand : NamedEntity, IOrderedEntity
    {
        [Table("Brands")] // указываем желаемое имя таблицы. Если этого не сделать, то таблица будет Brand (по имени класса)
        public int Order { get; set; }
        
/// <summary>
/// Virtual - укажет entity что Products это навигационное свойство
/// </summary>
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}