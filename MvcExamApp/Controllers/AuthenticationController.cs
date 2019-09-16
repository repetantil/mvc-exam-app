using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MvcExamApp.Controllers
{
    public class AuthenticationController : Controller
    {
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Authenticate([FromBody]string login, [FromBody]string password)
        {
            throw new NotImplementedException("Implement authentication. Check if user is admin and password the same as in config. " +
                "Generate token and return to client. Add to local ca");
            //return Ok(new { token = string.Empty });
        }
    }
}