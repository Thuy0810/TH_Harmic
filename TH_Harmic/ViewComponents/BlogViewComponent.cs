using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TH_Harmic.Models;

namespace TH_Harmic.ViewComponents
{
    public class BlogViewComponent : ViewComponent
    {
        private readonly TH_HarmicContext _context;

        public BlogViewComponent(TH_HarmicContext context)
        {

            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items= _context.TbBlogs.Include(m=>m.Category).Where(m=>(bool)m.IsActive).Where(m=>m.IsActive);
            return await Task.FromResult<IViewComponentResult>(View(items.OrderByDescending(m=>m.BlogId).ToList()));
        }
    }
}
