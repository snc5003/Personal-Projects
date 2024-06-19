using Sous_Chef_App.Data;

namespace Sous_Chef_App.Services;

public class MealPlanService : IMealPlanService
{
    private readonly IMealPlanData _mealPlanData;
    public MealPlanService(IMealPlanData mealPlanDataFromController)
    {
        _mealPlanData = mealPlanDataFromController;
    }
}