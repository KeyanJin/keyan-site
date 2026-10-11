using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using KeyanSite.Models;

namespace KeyanSite.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var hour = DateTime.Now.Hour;
        var greeting = hour switch
        {
            < 9 => "早上好",
            < 12 => "上午好",
            < 18 => "下午好",
            _ => "晚上好"
        };
        var model = new HomeViewModel
        {
            Greeting = greeting,
            Activities = new List<string>
            {
                "这是我的个人网站",
                "分享我的感受",
                "记录我的生活"
            }
        };

        return View(model);
    }

    public IActionResult About()
    {
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}