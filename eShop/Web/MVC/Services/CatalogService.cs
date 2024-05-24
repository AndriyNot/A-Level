using MVC.Dtos;
using MVC.Models.Enums;
using MVC.Services.Interfaces;
using MVC.ViewModels;

namespace MVC.Services;

public class CatalogService : ICatalogService
{
    private readonly IOptions<AppSettings> _settings;
    private readonly IHttpClientService _httpClient;
    private readonly ILogger<CatalogService> _logger;

    public CatalogService(IHttpClientService httpClient, ILogger<CatalogService> logger, IOptions<AppSettings> settings)
    {
        _httpClient = httpClient;
        _settings = settings;
        _logger = logger;
        
    }

    public async Task<Catalogs> GetCatalogItems(int page, int take, int? brand, int? type)
    {
        var filters = new Dictionary<CatalogTypeFilter, int>();

        if (brand.HasValue)
        {
            filters.Add(CatalogTypeFilter.Brand, brand.Value);
        }
        
        if (type.HasValue)
        {
            filters.Add(CatalogTypeFilter.Type, type.Value);
        }
        
        var result = await _httpClient.SendAsync<Catalogs, PaginatedItemsRequest<CatalogTypeFilter>>($"{_settings.Value.CatalogUrl}/items",
           HttpMethod.Post, 
           new PaginatedItemsRequest<CatalogTypeFilter>()
            {
                PageIndex = page,
                PageSize = take,
                Filters = filters
            });

        return result;
    }

    public async Task<IEnumerable<CatalogBrand>> GetBrands()
    {
        var result = await _httpClient.SendAsync<List<CatalogBrand>, object>(
            $"{_settings.Value.CatalogUrl}/brands",
            HttpMethod.Get,
            null);

        var brands = result?.Select(b => new SelectListItem { Value = b.Id.ToString(), Text = b.Brand });
        return result ?? Enumerable.Empty<CatalogBrand>();
    }

    public async Task<IEnumerable<SelectListItem>> GetTypes()
    {
        var result = await _httpClient.SendAsync<List<CatalogType>, object>(
            $"{_settings.Value.CatalogUrl}/types",
            HttpMethod.Get,
            null);

        var types = result?.Select(t => new SelectListItem { Value = t.Id.ToString(), Text = t.Type });
        return types ?? Enumerable.Empty<SelectListItem>();
    }
}
