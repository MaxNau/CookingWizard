using CookingWizard.Models_;
using System.Collections.Generic;
using System.Linq;

namespace CookingWizard.ViewModels
{
    public class CookingWizardViewModel
    {
        public List<Meal> Meals { get; set; }
        public Meal SelectedMeal { get; set; }

        public CookingWizardViewModel()
        {
            Meals = new List<Meal>();
            SelectedMeal = new Meal();
            GetAllMeals();
        }

        private void GetAllMeals()
        {
            using (CookingWizardContext context = new CookingWizardContext())
            {
                Meals = context.Meals.ToList();
                foreach (Meal meal in Meals)
                {
                    meal.Recipe = context.Recipes.SingleOrDefault(r => meal.MealId == r.RecipeId);
                    meal.Recipe.Actions = context.Actions.Where(a => a.Recipe.RecipeId == meal.Recipe.RecipeId).ToList();
                    meal.Recipe.Ingredients = context.Ingredients.Where(i => i.Recipe.RecipeId == meal.Recipe.RecipeId).ToList();
                }
            }
        }
    }
}
