namespace CookingWizard.Models_
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CookingWizardContext : DbContext
    {
        public CookingWizardContext()
            : base("name=CookingWizardContext")
        {
            Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Action> Actions { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<Meal> Meals { get; set; }
        public virtual DbSet<Recipe> Recipes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>()
                .HasMany(e => e.Actions)
                .WithOptional(e => e.Recipe)
                .HasForeignKey(e => e.Recipe_RecipeId);

            modelBuilder.Entity<Recipe>()
                .HasMany(e => e.Ingredients)
                .WithOptional(e => e.Recipe)
                .HasForeignKey(e => e.Recipe_RecipeId);

            modelBuilder.Entity<Recipe>()
                .HasMany(e => e.Meals)
                .WithOptional(e => e.Recipe)
                .HasForeignKey(e => e.Recipe_RecipeId);
        }
    }
}
