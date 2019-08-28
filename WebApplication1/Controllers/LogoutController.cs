using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class LogoutController : Controller
    {
        public IActionResult Index()
        {
            return SignOut("Cookies", "oidc");
        }
    }
}