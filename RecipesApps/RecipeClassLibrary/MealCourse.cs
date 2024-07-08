using System;
using System.Collections.Generic;

namespace RecipeClassLibrary;

public partial class MealCourse
{
    public int MealCourseId { get; set; }

    public int MealId { get; set; }

    public int CourseId { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual Meal Meal { get; set; } = null!;

    public virtual ICollection<MealCourseRecipe> MealCourseRecipes { get; set; } = new List<MealCourseRecipe>();
}
