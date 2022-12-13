using DailyEnglish.Data.DbModels;
using DailyEnglish.Data.DTOs;

namespace DailyEnglish.Data
{
    public interface IQuoteDataService
    {
        List<QuoteDto> GetAllQuotes();
        List<Quote> SearchQuotes();
        int Insert(Quote quote);
        int Delete(Quote quote);
        int Update(Quote quote);
    }
}
