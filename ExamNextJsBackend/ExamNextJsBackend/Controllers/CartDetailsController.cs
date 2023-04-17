using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExamNextJsBackend.Entities;
using GripFoodBackEnd.Entities;
using static OpenIddict.Abstractions.OpenIddictConstants;
using ExamNextJsBackend.Models;

namespace ExamNextJsBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartDetailsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CartDetailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CartDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CartDetail>>> GetCartDetails()
        {
          if (_context.CartDetails == null)
          {
              return NotFound();
          }
            return await _context.CartDetails.ToListAsync();
        }

        // GET: api/CartDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CartDetail>> GetCartDetail(string id)
        {
          if (_context.CartDetails == null)
          {
              return NotFound();
          }
            var cartDetail = await _context.CartDetails.FindAsync(id);

            if (cartDetail == null)
            {
                return NotFound();
            }

            return cartDetail;
        }

        // PUT: api/CartDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCartDetail(string id, CartDetail cartDetail)
        {
            if (id != cartDetail.Id)
            {
                return BadRequest();
            }

            _context.Entry(cartDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CartDetailExists(id))
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

        // POST: api/CartDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<bool>> PostCartDetail(AddToCartModel model)
        {
            if (_context.Carts == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Carts'  is null.");
            }

            var cartId = User.FindFirst(Claims.Subject)?.Value ?? throw new InvalidOperationException("User ID not found");

            var existing = await _context.CartDetails
                .Where(Q => Q.FoodItemId == model.FoodItemId && Q.CartId == cartId)
                .FirstOrDefaultAsync();
            var id = Ulid.NewUlid().ToString();

            if (existing != null)
            {
                existing.Quantity += model.Quantity;
            }
            else
            {
                _context.CartDetails.Add(new CartDetail
                {
                    Id = id,
                    CartId = cartId,
                    FoodItemId = model.FoodItemId,
                    Quantity = model.Quantity

                });
            }

            await _context.SaveChangesAsync();
            return true;
        }

        // DELETE: api/CartDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCartDetail(string id)
        {
            if (_context.CartDetails == null)
            {
                return NotFound();
            }
            var cartDetail = await _context.CartDetails.FindAsync(id);
            if (cartDetail == null)
            {
                return NotFound();
            }

            _context.CartDetails.Remove(cartDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CartDetailExists(string id)
        {
            return (_context.CartDetails?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
