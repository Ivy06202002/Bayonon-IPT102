using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Ivy Bayonon", StudentId = "S001", StudentAge = "21" },
            new StudentInfoModel { Name = "Summer Bayonon", StudentId = "S002", StudentAge = "22" },
            new StudentInfoModel { Name = "Kate Bayonon", StudentId = "S003", StudentAge = "31" }
        };

        return View(studentInfoArray);
    }
}
