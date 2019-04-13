using System.ComponentModel.DataAnnotations.Schema;
using WebStore.Domain.Entities.Base;
using WebStore.Domain.Entities.Base.Interfaces;

namespace WebStore.Domain.Entities
{
    [Table("Products")]
    public class Product : NamedEntity, IOrderedEntity
    
    {
        public int Order { get; set; }
        
        public int SectionId { get; set; }
        
        [ForeignKey(nameof(SectionId))] // Указываем связь по внешнему ключу для данного навигационного свойства
        public virtual Section Section { get; set; }
        
        public int? BrandId { get; set; }
        
        [ForeignKey(nameof(BrandId))]
        public virtual Brand Brand { get; set; }
        public string ImageUrl { get; set; }
        
        public decimal Price { get; set; }
        
        
    }
}