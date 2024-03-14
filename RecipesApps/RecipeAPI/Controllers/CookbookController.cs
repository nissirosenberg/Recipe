using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeSystem;

namespace RecipeAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class CookbookController : ControllerBase
    {
        [HttpGet]
        public List<bizCookbook> Get()
        {
            bizCookbook cookbook = new();
            List<bizCookbook> allcookbooks = cookbook.GetList();
            return allcookbooks;
        }

        [HttpGet("getbyid/{cookbookid:int:min(1)}")]
        public List<bizCookbook> Get(int cookbookid)
        {
            return new bizCookbook().LoadByCookbookId(cookbookid);
        }
    }
}
