using DailyEnglish01.Models;

namespace DailyEnglish01.Services
{
    public interface IQuoteDataService
    {
        List<QuoteModel> GetAllQuotes();
        List<QuoteModel> SearchQuotes();
        int Insert(QuoteModel quote);
        int Delete(QuoteModel quote);
        int Update(QuoteModel quote);
    }
}
