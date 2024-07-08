using Microsoft.AspNetCore.Mvc;
using RecipeClassLibrary;

namespace MVCRecipeWebsite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class recipesController1 : Controller
    {
        //public DataContext(System.Data.IDbConnection connection);

        [HttpGet,Route("GetRecipe")]
        public List<Recipe> GetRecipes() {

            //Recipe recipe = new();
            //List<Recipe> allrecipes = recipe.ToList();
            return new List<Recipe>();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
