using System;
using System.Collections.Generic;

namespace RecipeClassLibrary;

public partial class Meal
{
    public int MealId { get; set; }

    public int UserId { get; set; }

    public string MealName { get; set; } = null!;

    public bool Active { get; set; }

    public DateOnly DateCreated { get; set; }

    public string MealDesc { get; set; } = null!;

    public virtual ICollection<MealCourse> MealCourses { get; set; } = new List<MealCourse>();

    public virtual User User { get; set; } = null!;
}
