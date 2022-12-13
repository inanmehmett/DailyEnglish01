using DailyEnglish01.Models;
using System.Data.SqlClient;

namespace DailyEnglish01.Services
{
    public class QuotesDAO : IQuoteDataService
    {
        string connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=Test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public int Delete(QuoteModel quote)
        {
            throw new NotImplementedException();
        }
        public List<QuoteModel> GetAllQuotes()
        {
            List<QuoteModel> quotesList = new List<QuoteModel>();
            string sqlStatement = "SELECT * FROM dbo.quote";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
            SqlCommand command = new SqlCommand(sqlStatement, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        quotesList.Add(new QuoteModel { Id = (int)reader[0], Author = (string)reader[1], DescriptionEn = (string)reader[2], DescriptionTr = (string)reader[3] });
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return quotesList;
            }

        }

        public int Insert(QuoteModel quote)
        {
            throw new NotImplementedException();
        }
            public List<QuoteModel> SearchQuotes(string searchTerm)
            {
                List<QuoteModel> foundQuote = new List<QuoteModel>();
                string sqlStatement = "SELECT * FROM dbo.quote WHERE Description LIKE @DescriptionEn";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(sqlStatement, connection);
                    command.Parameters.AddWithValue("@DescriptionEn", '%' + searchTerm + '%');
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            foundQuote.Add(new QuoteModel { Id = (int)reader[0], Author = (string)reader[1], DescriptionEn = (string)reader[2], DescriptionTr = (string)reader[3] });
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    return foundQuote;
                }
            }

        public List<QuoteModel> SearchQuotes()
        {
            throw new NotImplementedException();
        }

        public int Update(QuoteModel quote)
        {
            throw new NotImplementedException();
        }
    }
}
