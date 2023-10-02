using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace TeamFive.Controllers;
public class PublicController : Controller
{
    //This controller's only purpose is to serve up the react app in Production.
    //Nothing more should be added here, except maybe a catch-all route.
	public ViewResult Index()
	{
		return View();
	}
}
