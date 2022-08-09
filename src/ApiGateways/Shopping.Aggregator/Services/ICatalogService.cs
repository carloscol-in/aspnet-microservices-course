using Shopping.Aggregator.Models;

namespace Shopping.Aggregator.Services
{
    public interface ICatalogService
    {
        Task<IEnumerable<CatalogModel>> GetCatalog();
        Task<IEnumerable<CatalogModel>> GetCatalogByCategorty(string category);
        Task<CatalogModel> GetCatalog(string id);
    }
}
