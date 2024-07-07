using System;
using System.Collections.Generic;

namespace RecipeClassLibrary;

public partial class Measurement
{
    public int MeasurementId { get; set; }

    public string MeasurementName { get; set; } = null!;

    public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();
}
