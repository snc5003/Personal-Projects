using Sous_Chef_App.Models;

namespace Sous_Chef_App.Data;

public class MealPlanData : IMealPlanData
{
    private readonly IMealPlanData _mealPlanData;

    public MealPlanData(IMealPlanData mealPlanDataFromBuilder)
    {
        _mealPlanData = mealPlanDataFromBuilder;
    }
}