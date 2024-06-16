namespace Sous_Chef_App.Models;

public class MealPlans
{
    public Guid mealPlanId {get;set;}
    public List<Guid> recipeIds {get;set;}
    public List<string> mealNames {get; set;}
    public Guid userId {get; set;}

   public MealPlans(){}


    public MealPlans(List<Guid> _recipeIds, List<string> _mealNames)
    {
        mealPlanId = Guid.NewGuid();
        recipeIds = _recipeIds;
        mealNames = _mealNames;
    }


    public MealPlans(Guid _mealPlanId, List<Guid> _recipeIds, List<string> _mealNames)
    {
        mealPlanId = _mealPlanId;
        recipeIds = _recipeIds;
        mealNames = _mealNames;
    }

}