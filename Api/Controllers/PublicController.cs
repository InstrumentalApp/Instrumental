using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace TeamFive.Controllers;
public class PublicController : Controller
{

    private readonly IWebHostEnvironment _hostingEnvironment;

    public PublicController(IWebHostEnvironment hostingEnvironment)
    {
        _hostingEnvironment = hostingEnvironment;
    }
	public IActionResult Production()
	{
		var filePath = Path.Combine(_hostingEnvironment.WebRootPath, "index.html");
        return PhysicalFile(filePath, "text/html");
	}

	public ViewResult Index()
	{
        return View();
	}
}
