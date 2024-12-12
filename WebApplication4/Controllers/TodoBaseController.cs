using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace WebApplication4.Controllers
{
    public class TodoBaseController : Controller
    {
        protected int CurrentUserId => int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
    }
}
