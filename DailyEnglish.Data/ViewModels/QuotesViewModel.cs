using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyEnglish.Data.ViewModels
{
    internal class QuotesViewModel
    {
        public int Page { get; set; }
        public int Size { get; set; }
        public List<QuoteViewModel> Quotes { get; set; }
    }
}
