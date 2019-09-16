using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MvcExamApp.Controllers
{
    public class TeamController : Controller
    {
        [Authorize]
        public IActionResult Index(string[] teams)
        {
            throw new NotImplementedException("Implement reading from TeamsProvider number of employees per team." +
                "Inject TeamsProvider using DI as a SINGLETONE." +
                "Add local server cache, so you don't need to call a service if a value exists in the cahce");

            //return Ok()
        }
    }
}