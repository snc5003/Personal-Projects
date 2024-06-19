using Microsoft.AspNetCore.Mvc;
using Sous_Chef_App.Services;

namespace Sous_Chef_App.Controllers;

[ApiController]
[Route("[controller]")]
public class MealPlanController : ControllerBase
{
    public IMealPlanService _mealPlanService;
    public MealPlanController(IMealPlanService mealPlanServiceFromBuilder)
    {
        _mealPlanService = mealPlanServiceFromBuilder;
    }

}
