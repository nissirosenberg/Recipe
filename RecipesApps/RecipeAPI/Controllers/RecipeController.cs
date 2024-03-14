using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeSystem;

namespace RecipeAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        [HttpGet]
        public List<bizRecipe> Get()
        {
            bizRecipe recipe = new();
            List<bizRecipe> allrecipes = recipe.GetList();
            return allrecipes;
        }

        [HttpGet("getbyid/{recipeid:int:min(1)}")]
        public List<bizRecipe> Get(int recipeid)
        {
            return new bizRecipe().LoadByRecipeId(recipeid);
        }

        [HttpGet("getbycookbook/{uniquecookbookid}")]
        public List<bizRecipe> GetByCookbook(string uniquecookbookid)
        {
            return new bizRecipe().LoadByCookbookId(uniquecookbookid);
        }
    }
}
