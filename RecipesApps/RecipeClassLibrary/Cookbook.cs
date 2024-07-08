using System;
using System.Collections.Generic;

namespace RecipeClassLibrary;

public partial class Cookbook
{
    public int CookbookId { get; set; }

    public int UserId { get; set; }

    public string CookbookName { get; set; } = null!;

    public decimal Price { get; set; }

    public bool Active { get; set; }

    public DateOnly DateCreated { get; set; }

    public string CookbookPicture { get; set; } = null!;

    public int CookbookSkill { get; set; }

    public string? CookbookSkillDesc { get; set; }

    public string UniqueCookbookId { get; set; } = null!;

    public virtual ICollection<CookbookRecipe> CookbookRecipes { get; set; } = new List<CookbookRecipe>();

    public virtual User User { get; set; } = null!;
}
