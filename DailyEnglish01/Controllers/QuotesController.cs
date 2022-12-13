using DailyEnglish01.Models;
using DailyEnglish01.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace DailyEnglish01.Controllers
{
    public class QuotesController : Controller
    {
        // GET: QuotesController
        //public ActionResult Index(int p  = 1)
        //{
        //    QuoteService quotes = new QuoteService();
        //    return View(quotes.GetAllQuotes().ToPagedList(p, 4));
        //    //List<Quote> Quotes = new List<Quote>();
        //    //Quotes.Add(new Quote { Id = 0, Author = "mehmet", DescriptionEn = "hello", DescriptionTr="merhaba" });
        //    //Quotes.Add(new Quote { Id = 1, Author = "filiz", DescriptionEn = "ben", DescriptionTr = "me" });
        //    //Quotes.Add(new Quote { Id = 2, Author = "kerem", DescriptionEn = "namjfdf jfaksdfşsd jfke  jkej ekjf  jşdsfasdf jkdjfasdfw kşdjfasse", DescriptionTr = "isim" });
        //    //Quotes.Add(new Quote { Id = 3, Author = "ali", DescriptionEn = "school", DescriptionTr = "okul" });
        //    //return View(Quotes);
        //}
        public ActionResult Index() 
        {
            QuotesDAO quotes = new QuotesDAO();
            return View(quotes.GetAllQuotes());
            //List<Quote> Quotes = new List<Quote>();
            //Quotes.Add(new Quote { Id = 0, Author = "mehmet", DescriptionEn = "hello", DescriptionTr="merhaba" });
            //Quotes.Add(new Quote { Id = 1, Author = "filiz", DescriptionEn = "ben", DescriptionTr = "me" });
            //Quotes.Add(new Quote { Id = 2, Author = "kerem", DescriptionEn = "namjfdf jfaksdfşsd jfke  jkej ekjf  jşdsfasdf jkdjfasdfw kşdjfasse", DescriptionTr = "isim" });
            //Quotes.Add(new Quote { Id = 3, Author = "ali", DescriptionEn = "school", DescriptionTr = "okul" });
            //return View(Quotes);
        }
        public IActionResult SearchForm()
        {
            return View();
        }
        public IActionResult SearchResults(string searchTerm)
        {
            QuotesDAO quote = new QuotesDAO();
            List<QuoteModel> quoteList = quote.SearchQuotes(searchTerm);
            return View("index", quoteList);
        }
        // GET: QuotesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QuotesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuotesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: QuotesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QuotesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: QuotesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QuotesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
