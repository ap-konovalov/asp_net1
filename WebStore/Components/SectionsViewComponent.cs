using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebStore.Infrastructure.Interfaces;
using WebStore.ViewModels;

namespace WebStore.Components
{
    public class SectionsViewComponent: ViewComponent
    {
        private readonly IProductData _ProductData;

        public SectionsViewComponent(IProductData ProductData)
        {
            _ProductData = ProductData;
        }

        public IViewComponentResult Invoke()
        {
            var section = GetSections();
            return View();
        }
        
//        public async Task<IViewComponentResult> InvokeAsync() {}

        private IEnumerable<SectionViewModel> GetSections()
        {
            var sections = _ProductData.GetSections();

            var parent_sections = sections
                .Where(section => section.ParentId == null)
                .Select(section => new SectionViewModel
                {
                    Id = section.Id,
                    Name = section.Name,
                    Order = section.Order
                })
                .ToList();

            foreach (var parent_section in parent_sections)
            {
                var child_sections = sections
                    .Where(section => section.ParentId == parent_section.Id)
                    .Select(section => new SectionViewModel
                    {
                        Id = section.Id,
                        Name = section.Name,
                        Order = section.Order
                    });
                parent_section.ChildSection.AddRange(child_sections);
                parent_section.ChildSection.Sort((a,b) => Comparer<int>.Default.Compare(a.Order, b.Order));                
            }
            parent_sections.Sort((a,b) => Comparer<int>.Default.Compare(a.Order, b.Order));
            return parent_sections;
        }
    }
}