using Microsoft.AspNetCore.Mvc;
using webApp.Models;

namespace webApp.Controllers
{
    public class ContentController : Controller
    {
        public IActionResult Index()
        {
            var contents = new List<Content>();
            for (int i = 0; i < 10; i++)
            {
                contents.Add(new Content { Id = i, Title = $"第{i}条数据标题", Detail = $"第{i}条数据的内容", Status = 1, Add_time = DateTime.Now.AddDays(-i) });
            }
            return View(new ContentViewModel { Contents = contents});
        }
    }
}
