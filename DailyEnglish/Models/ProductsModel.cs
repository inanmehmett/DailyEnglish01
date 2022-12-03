using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DailyEnglish.Models
{
    public class ProductsModel
    {
        [DisplayName("Id Number")]
        public int Id { get; set; }
        [DisplayName("Product Name")]
        public string Name { get; set; }
        [DisplayName("Product Price")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [DisplayName("Total Price")]
        public decimal PriceTotal { get; set; }
        [DisplayName("Description")]
        public string Description { get; set; }
    }
}
