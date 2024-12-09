using Microsoft.AspNetCore.Mvc;
using TH_Harmic.Models;
using Microsoft.EntityFrameworkCore;

namespace TH_Harmic.ViewComponents
{
    public class MenuTopViewComponent : ViewComponent
    {
        private readonly TH_HarmicContext _context;

        public MenuTopViewComponent(TH_HarmicContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = _context.TbMenus.Where(m => (bool)m.IsActive).OrderBy(m => m.Position).ToList();
               
            return await Task.FromResult<IViewComponentResult >(View(items));
        }
    }
}
