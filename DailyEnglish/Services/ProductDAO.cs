using DailyEnglish.Models;
using System.Data.SqlClient;

namespace DailyEnglish.Services
{
    public class ProductDAO : IproductDataService
    {
        string connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=Test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public int Delete(ProductsModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductsModel> GetAllProducts()
        {
            List<ProductsModel> foundProducts = new List<ProductsModel>();
            string sqlStatement = "SELECT * FROM dbo.Products";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        foundProducts.Add(new ProductsModel { Id = (int)reader[0], Name = (string)reader[1], Price = (decimal)reader[2], Description = (string)reader[3] });
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return foundProducts;
            }
        }

        public ProductsModel GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductsModel> GetProducts()
        {
            throw new NotImplementedException();
        }

        public int Insert(ProductsModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductsModel> SearchProducts(string searchTerm)
        {
            List<ProductsModel> foundProducts = new List<ProductsModel>();
            string sqlStatement = "SELECT * FROM dbo.Products WHERE Name LIKE @Name";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@Name", '%' + searchTerm + '%');
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        foundProducts.Add(new ProductsModel { Id = (int)reader[0], Name = (string)reader[1], Price = (decimal)reader[2], Description = (string)reader[3] });
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return foundProducts;
            }
        }
        public int Update(ProductsModel product)
        {
            throw new NotImplementedException();
        }
    }
}
