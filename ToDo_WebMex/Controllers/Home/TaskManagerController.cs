using Microsoft.AspNetCore.Mvc;

namespace ToDo_WebMex.Controllers.Home
{
    public class TaskManagerController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Home/TaskManager/Index.cshtml");
        }
    }
}
