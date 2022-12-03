using Microsoft.CodeAnalysis.Completion;
using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DailyEnglish.Models
{
    public class LessonScheduleModel
    {
        [Required]
        [DisplayName("Enter the Student Name")]
        public string StudentName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Enter the Lessson Date")]
        public DateTime LessonDate { get; set; }

        [Required]
        [Range(1,6)]
        public decimal StudentLevel { get; set; }

        [Required]
        public string TeacherName { get; set; }
    }
}
