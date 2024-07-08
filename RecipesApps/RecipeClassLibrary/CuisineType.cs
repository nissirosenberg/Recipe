using System;
using System.Collections.Generic;

namespace RecipeClassLibrary;

public partial class CuisineType
{
    public int CuisineTypeId { get; set; }

    public string CuisineTypeName { get; set; } = null!;

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
}
