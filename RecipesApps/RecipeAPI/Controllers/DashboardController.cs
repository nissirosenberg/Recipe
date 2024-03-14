using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeSystem;

namespace RecipeAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        public DashboardController() { }
        [HttpGet]
        public List<bizDashboard> Get()
        {
            bizDashboard dashboard = new();
            List<bizDashboard> alldashboardinfo = dashboard.GetTotalRecipesMealsCookbooks();
            return alldashboardinfo;
        }
    }
}
