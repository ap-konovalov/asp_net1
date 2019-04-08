using System.Collections.Generic;
using System.Collections.Specialized;
using WebStore.Domain.Entities;

namespace WebStore.Data
{
    public class TestData
    {
        public static List<Section> Sections { get; } = new List<Section>
        {
            new Section {Id = 1, Name = "Спорт", Order = 0},
            new Section {Id = 2, Name = "Nike", Order = 0, ParentId = 1},
            new Section {Id = 3, Name = "Under Armour", Order = 1, ParentId = 1},
            new Section {Id = 4, Name = "Adidas", Order = 2, ParentId = 1},
            new Section {Id = 5, Name = "Puma", Order = 3, ParentId = 1},
            new Section {Id = 6, Name = "ASICS", Order = 4, ParentId = 1},
            new Section {Id = 7, Name = "Мужские", Order = 1},
            new Section {Id = 8, Name = "Fendi", Order = 0, ParentId = 7},
            new Section {Id = 9, Name = "Guess", Order = 1, ParentId = 7},
            new Section {Id = 10, Name = "Valentino", Order = 2, ParentId = 7},
            new Section {Id = 11, Name = "Dior", Order = 3, ParentId = 7},
            new Section {Id = 12, Name = "Версаче", Order = 4, ParentId = 7},
            new Section {Id = 13, Name = "Армани", Order = 5, ParentId = 7},
            new Section {Id = 14, Name = "Прада", Order = 6, ParentId = 7},
            new Section {Id = 15, Name = "Дольче-Габбана", Order = 7, ParentId = 7},
            new Section {Id = 16, Name = "Шанель", Order = 8, ParentId = 7},
            new Section {Id = 17, Name = "Гуччи", Order = 9, ParentId = 7},
            new Section {Id = 18, Name = "Женские", Order = 2},
            new Section {Id = 19, Name = "Фенди", Order = 0, ParentId = 18},
            new Section {Id = 20, Name = "Guess", Order = 1, ParentId = 18},
            new Section {Id = 21, Name = "Валентино", Order = 2, ParentId = 18},
            new Section {Id = 22, Name = "Диор", Order = 3, ParentId = 18},
            new Section {Id = 23, Name = "Versace", Order = 4, ParentId = 18},
            new Section {Id = 24, Name = "Детские", Order = 3},
            new Section {Id = 25, Name = "Мода", Order = 4},
            new Section {Id = 26, Name = "Для дома", Order = 5},
            new Section {Id = 27, Name = "Интерьер", Order = 6},
            new Section {Id = 28, Name = "Одежда", Order = 7},
            new Section {Id = 29, Name = "Сумки", Order = 8},
            new Section {Id = 30, Name = "Обувь", Order = 9}
        };

        public static List<Brand> Brands { get; } = new List<Brand>
        {
            new Brand {Id = 1, Name = "Acne", Order = 0},
            new Brand {Id = 2, Name = "Grune Erde", Order = 1},
            new Brand {Id = 3, Name = "Albiro", Order = 2},
            new Brand {Id = 4, Name = "Ronhill", Order = 3},
            new Brand {Id = 5, Name = "Oddmolly", Order = 4},
            new Brand {Id = 6, Name = "Boudestijn", Order = 5},
            new Brand {Id = 7, Name = "Rosch creative culture", Order = 6}
        };
    }
}