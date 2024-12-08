using MVC.ViewModels;

namespace MVC.Services.Interfaces;

public interface ICatalogService
{
    Task<Catalogs> GetCatalogItems(int page, int take, int? brand, int? type);
    Task<IEnumerable<CatalogBrand>> GetBrands();
    Task<IEnumerable<SelectListItem>> GetTypes();
}
