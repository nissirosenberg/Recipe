using System;
using System.Collections.Generic;

namespace RecipeClassLibrary;

public partial class RecipeDirection
{
    public int RecipeDirectionsId { get; set; }

    public int RecipeId { get; set; }

    public int DirectionsSequence { get; set; }

    public string Directions { get; set; } = null!;

    public virtual Recipe Recipe { get; set; } = null!;
}
