using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeSystem;

namespace RecipeAP
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealController : ControllerBase
    {
        [HttpGet]
        public List<bizMeal> Get()
        {
            bizMeal meal = new();
            List<bizMeal> allmeals = meal.GetList();
            return allmeals;
        }
    }
}
