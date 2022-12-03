using DailyEnglish.Models;

namespace DailyEnglish.Services
{
    public interface IproductDataService
    {
        List<ProductsModel> GetProducts();
        List<ProductsModel> GetAllProducts();
        List<ProductsModel> SearchProducts(string ssearchTerm);
        ProductsModel GetProductById(int id);
        int Insert(ProductsModel product); 
        int Update(ProductsModel product);
        int Delete(ProductsModel product);
    }
}
