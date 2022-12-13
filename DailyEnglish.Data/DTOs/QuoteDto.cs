using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyEnglish.Data.DTOs
{
    public class QuoteDto
    {
        [DisplayName("Id Number")]
        public int Id { get; set; }
        [DisplayName("Author Name")]
        public string Author { get; set; }
        public string DescriptionEn { get; set; }
        public string DescriptionTr { get; set; }
    }
}
