using Bogus;
using DailyEnglish.Models;
using System.Data.SqlClient;

namespace DailyEnglish.Services
{
    public class HardCodedSampleDataRepository : IproductDataService
    {
        static List<ProductsModel> productList = new List<ProductsModel>();
        string connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=Test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public int Delete(ProductsModel product)
        {
            throw new NotImplementedException();
        }

        public ProductsModel GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductsModel> GetProducts()
        {
            if (productList.Count == 0)
            {
                for (int i = 0; i < 100; i++)
                {
                    productList.Add(new Faker<ProductsModel>()
                        .RuleFor(p => p.Id, i + 5)
                        .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                        .RuleFor(p => p.Price, f => f.Random.Decimal(100))
                        .RuleFor(p => p.Description, f => f.Rant.Review())
                        );
                }

            }


            return productList;

        }
        public List<ProductsModel> GetAllProducts()
        {
            throw new NotImplementedException();
        }
        public int Insert(ProductsModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductsModel> SearchProducts(string ssearchTerm)
        {
            throw new NotImplementedException();
        }

        public int Update(ProductsModel product)
        {
            throw new NotImplementedException();
        }
    }
}
