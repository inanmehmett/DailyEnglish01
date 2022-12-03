using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace DailyEnglish.Models
{
    public class CustomerModel
    {
        [Required]
        public string CustomerName { get; set; }
        public string CustomerStreet { get; set; }
        [Required]
        public string CustomerCity { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public int CustomerPhone { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string CustomerEmail { get; set; }
        [Range(6,6)]
        public int CustomerZipCode { get; set; }
    }
}
