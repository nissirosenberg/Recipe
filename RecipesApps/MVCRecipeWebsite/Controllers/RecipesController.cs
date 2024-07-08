using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RecipeClassLibrary;

namespace MVCRecipeWebsite.Controllers
{
    public class RecipesController : Controller
    {
        private readonly HeartyHearthDbContext _context;

        public RecipesController(HeartyHearthDbContext context)
        {
            _context = context;
        }

        [HttpGet, Route("GetRecipes")]
        public async Task<List<Recipe>> GetRecipes()
        {
            return await _context.Recipes.ToListAsync();
        }

        // GET: Recipes
        public async Task<IActionResult> Index()
        {
            var heartyHearthDbContext = _context.Recipes.Include(r => r.CuisineType).Include(r => r.User);
            return View(await heartyHearthDbContext.ToListAsync());
        }

        // GET: Recipes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipe = await _context.Recipes
                .Include(r => r.CuisineType)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.RecipeId == id);
            if (recipe == null)
            {
                return NotFound();
            }

            return View(recipe);
        }

        // GET: Recipes/Create
        public IActionResult Create()
        {
            ViewData["CuisineTypeId"] = new SelectList(_context.CuisineTypes, "CuisineTypeId", "CuisineTypeName");
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserFirstName");
            return View();
        }

        // POST: Recipes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RecipeId,UserId,CuisineTypeId,RecipeName,Calories,DateDrafted,DatePublished,DateArchived,CurrentStatus,RecipePicture,Vegan")] Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                _context.Add(recipe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CuisineTypeId"] = new SelectList(_context.CuisineTypes, "CuisineTypeId", "CuisineTypeName", recipe.CuisineTypeId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserFirstName", recipe.UserId);
            return View(recipe);
        }

        // GET: Recipes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipe = await _context.Recipes.FindAsync(id);
            if (recipe == null)
            {
                return NotFound();
            }
            ViewData["CuisineTypeId"] = new SelectList(_context.CuisineTypes, "CuisineTypeId", "CuisineTypeName", recipe.CuisineTypeId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserFirstName", recipe.UserId);
            return View(recipe);
        }

        // POST: Recipes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RecipeId,UserId,CuisineTypeId,RecipeName,Calories,DateDrafted,DatePublished,DateArchived,CurrentStatus,RecipePicture,Vegan")] Recipe recipe)
        {
            if (id != recipe.RecipeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(recipe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecipeExists(recipe.RecipeId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CuisineTypeId"] = new SelectList(_context.CuisineTypes, "CuisineTypeId", "CuisineTypeName", recipe.CuisineTypeId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserFirstName", recipe.UserId);
            return View(recipe);
        }

        // GET: Recipes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipe = await _context.Recipes
                .Include(r => r.CuisineType)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.RecipeId == id);
            if (recipe == null)
            {
                return NotFound();
            }

            return View(recipe);
        }

        // POST: Recipes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var recipe = await _context.Recipes.FindAsync(id);
            if (recipe != null)
            {
                _context.Recipes.Remove(recipe);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RecipeExists(int id)
        {
            return _context.Recipes.Any(e => e.RecipeId == id);
        }
    }
}
