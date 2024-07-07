using System;
using System.Collections.Generic;

namespace RecipeClassLibrary;

public partial class Recipe
{
    public int RecipeId { get; set; }

    public int UserId { get; set; }

    public int CuisineTypeId { get; set; }

    public string RecipeName { get; set; } = null!;

    public int Calories { get; set; }

    public DateTime DateDrafted { get; set; }

    public DateTime? DatePublished { get; set; }

    public DateTime? DateArchived { get; set; }

    public string CurrentStatus { get; set; } = null!;

    public string RecipePicture { get; set; } = null!;

    public bool Vegan { get; set; }

    public virtual ICollection<CookbookRecipe> CookbookRecipes { get; set; } = new List<CookbookRecipe>();

    public virtual CuisineType CuisineType { get; set; } = null!;

    public virtual ICollection<MealCourseRecipe> MealCourseRecipes { get; set; } = new List<MealCourseRecipe>();

    public virtual ICollection<RecipeDirection> RecipeDirections { get; set; } = new List<RecipeDirection>();

    public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();

    public virtual User User { get; set; } = null!;
}
