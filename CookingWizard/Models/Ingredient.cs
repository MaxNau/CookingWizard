namespace CookingWizard.Models_
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ingredient
    {
        public int IngredientId { get; set; }

        public string Name { get; set; }

        public int? Recipe_RecipeId { get; set; }

        public virtual Recipe Recipe { get; set; }
    }
}
