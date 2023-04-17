using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExamNextJsBackend.Entities;
using GripFoodBackEnd.Entities;
using ExamNextJsBackend.Models;
using Microsoft.AspNetCore.Authorization;

namespace ExamNextJsBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize("api")]
    public class FoodItemsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FoodItemsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/FoodItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FoodItem>>> GetFoodItems()
        {
          if (_context.FoodItems == null)
          {
              return NotFound();
          }
            return await _context.FoodItems.ToListAsync();
        }

        // GET: api/FoodItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<List<FoodItemDetailModel>>> GetRestaurant(string id)
        {
            if (_context.Restaurants == null)
            {
                return NotFound();
            }
            var foodItem = await _context.FoodItems
                .AsNoTracking()
                .Where(Q => Q.Id == id)
                .Select(Q => new FoodItemDetailModel
                {
                    Id = Q.Id,
                    Name = Q.Name,
                    Price = Q.Price,
                    RestaurantId = Q.Restaurant.Id,
                })
                .ToListAsync();

            if (foodItem == null)
            {
                return NotFound();
            }

            return foodItem;
        }

        // PUT: api/FoodItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFoodItem(string id, FoodItem foodItem)
        {
            if (id != foodItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(foodItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FoodItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/FoodItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FoodItem>> PostFoodItem(FoodItem foodItem)
        {
          if (_context.FoodItems == null)
          {
              return Problem("Entity set 'ApplicationDbContext.FoodItems'  is null.");
          }
            _context.FoodItems.Add(foodItem);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (FoodItemExists(foodItem.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetFoodItem", new { id = foodItem.Id }, foodItem);
        }

        // DELETE: api/FoodItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFoodItem(string id)
        {
            if (_context.FoodItems == null)
            {
                return NotFound();
            }
            var foodItem = await _context.FoodItems.FindAsync(id);
            if (foodItem == null)
            {
                return NotFound();
            }

            _context.FoodItems.Remove(foodItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FoodItemExists(string id)
        {
            return (_context.FoodItems?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
