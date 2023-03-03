using Sales.Shared.Entities;

namespace Sales.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckCountriesAsync();
            await CheckCategoriesAsync();
        }

        private async Task CheckCountriesAsync()
        {
            if (!_context.Countries.Any())
            {
                _context.Countries.Add(new Country { Name = "Colombia" });
                _context.Countries.Add(new Country { Name = "Perú" });
                _context.Countries.Add(new Country { Name = "México" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckCategoriesAsync()
        {
            if (!_context.Categories.Any())
            {
                _context.Categories.Add(new Category { Name = "Categoria 1" });
                _context.Categories.Add(new Category { Name = "Categoria 2" });
                _context.Categories.Add(new Category { Name = "Categoria 3" });
                _context.Categories.Add(new Category { Name = "Categoria 4" });
                _context.Categories.Add(new Category { Name = "Categoria 5" });
                _context.Categories.Add(new Category { Name = "Categoria 6" });
                _context.Categories.Add(new Category { Name = "Categoria 7" });
                _context.Categories.Add(new Category { Name = "Categoria 8" });
                _context.Categories.Add(new Category { Name = "Categoria 9" });
                _context.Categories.Add(new Category { Name = "Categoria 10" });
                await _context.SaveChangesAsync();
            }
        }
    }
}
