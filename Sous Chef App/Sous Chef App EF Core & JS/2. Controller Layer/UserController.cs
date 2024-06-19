using Microsoft.AspNetCore.Mvc;
using Sous_Chef_App.Services;

namespace Sous_Chef_App.Controllers;

[ApiController]
[Route("Users")]
public class UserController : ControllerBase
{
    public readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }
}