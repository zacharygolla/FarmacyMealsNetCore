using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FarmacyMeals.WebApi.Data;
using FarmacyMeals.WebApi.Models.Food;
using FarmacyMeals.WebApi.Handlers.Food;

namespace FarmacyMeals.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodsController : ControllerBase
    {
        private readonly FoodHandler _foodHandler;

        public FoodsController(FoodHandler foodHandler)
        {
            _foodHandler = foodHandler;
        }

        // GET: api/Foods
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FoodModelDto>>> GetFoods()
        {
            return await _foodHandler.GetAllFoodsAsync();
        }

        //// GET: api/Foods/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Food>> GetFood(Guid? id)
        //{
        //    var food = await _context.Foods.FindAsync(id);

        //    if (food == null)
        //    {
        //        return NotFound();
        //    }

        //    return food;
        //}

        //// PUT: api/Foods/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutFood(Guid? id, Food food)
        //{
        //    if (id != food.FoodId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(food).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!FoodExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Foods
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Food>> PostFood(Food food)
        //{
        //    _context.Foods.Add(food);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetFood", new { id = food.FoodId }, food);
        //}

        //// DELETE: api/Foods/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteFood(Guid? id)
        //{
        //    var food = await _context.Foods.FindAsync(id);
        //    if (food == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Foods.Remove(food);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool FoodExists(Guid? id)
        //{
        //    return _context.Foods.Any(e => e.FoodId == id);
        //}
    }
}
