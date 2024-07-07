using System;
using System.Collections.Generic;

namespace RecipeClassLibrary;

public partial class CookbookRecipe
{
    public int CookbookRecipeId { get; set; }

    public int CookbookId { get; set; }

    public int RecipeId { get; set; }

    public int RecipeSequence { get; set; }

    public virtual Cookbook Cookbook { get; set; } = null!;

    public virtual Recipe Recipe { get; set; } = null!;
}
