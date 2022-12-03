using DailyEnglish.Models;
using Microsoft.AspNetCore.Mvc;

namespace DailyEnglish.Controllers
{
    public class LessonSchedule : Controller
    {
        static List<LessonScheduleModel>schedules = new List<LessonScheduleModel>();
        public IActionResult Index()
        {
            return View(schedules);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit(LessonSchedule schedule)
        {
            return View();
        }

        public IActionResult Details(LessonScheduleModel schedule)
        {
            schedules.Add(schedule);
            return View("Details", schedule);
        }
    }
}
