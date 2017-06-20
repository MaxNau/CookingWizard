namespace CookingWizard.Models_
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Action")]
    public partial class Action
    {
        public int Id { get; set; }

        public string Context { get; set; }

        public int? Recipe_RecipeId { get; set; }

        public virtual Recipe Recipe { get; set; }
    }
}
