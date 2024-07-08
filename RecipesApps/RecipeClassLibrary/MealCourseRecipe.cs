using System;
using System.Collections.Generic;

namespace RecipeClassLibrary;

public partial class MealCourseRecipe
{
    public int MealCourseRecipeId { get; set; }

    public int MealCourseId { get; set; }

    public int RecipeId { get; set; }

    public bool MainDish { get; set; }

    public virtual MealCourse MealCourse { get; set; } = null!;

    public virtual Recipe Recipe { get; set; } = null!;
}
