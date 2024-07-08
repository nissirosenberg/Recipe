using System;
using System.Collections.Generic;

namespace RecipeClassLibrary;

public partial class Course
{
    public int CourseId { get; set; }

    public int CourseSequence { get; set; }

    public string CourseName { get; set; } = null!;

    public virtual ICollection<MealCourse> MealCourses { get; set; } = new List<MealCourse>();
}
