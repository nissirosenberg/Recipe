using System;
using System.Collections.Generic;

namespace RecipeClassLibrary;

public partial class RecipeIngredient
{
    public int RecipeIngredientId { get; set; }

    public int RecipeId { get; set; }

    public int? MeasurementId { get; set; }

    public int IngredientId { get; set; }

    public decimal Amount { get; set; }

    public int IngredientSequence { get; set; }

    public virtual Ingredient Ingredient { get; set; } = null!;

    public virtual Measurement? Measurement { get; set; }

    public virtual Recipe Recipe { get; set; } = null!;
}
