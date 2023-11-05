using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace TeamFive.Controllers;
public class PublicController : Controller
{

    private readonly IWebHostEnvironment _hostingEnvironment;
    private readonly ILogger<PublicController> _logger;

    public PublicController(IWebHostEnvironment hostingEnvironment, ILogger<PublicController> logger)
    {
        _hostingEnvironment = hostingEnvironment;
        _logger = logger;
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
