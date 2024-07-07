using System;
using System.Collections.Generic;

namespace RecipeClassLibrary;

public partial class User
{
    public int UserId { get; set; }

    public string UserFirstName { get; set; } = null!;

    public string UserLastName { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public virtual ICollection<Cookbook> Cookbooks { get; set; } = new List<Cookbook>();

    public virtual ICollection<Meal> Meals { get; set; } = new List<Meal>();

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
}
