using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiProject.Data;
using HotelManagemant.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiProject.Controllers
{

    [Produces("application/json")]

    [Route("api/[controller]")]
    [ApiController]
    [Authorize]

    public class HotelController : ControllerBase
    {
        private ApiExampleDbContext api;
        public HotelController(ApiExampleDbContext _api)
        {
            this.api = _api;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hotel>>> GetHotels() {
           // return await api.hotels.ToListAsync();
          return Ok(await api.hotels.ToListAsync());


        }
        [HttpGet("{id}",Name ="GetHotels")]
        public async Task<IActionResult> GetHotels([FromRoute]int id) {

           return Ok(await api.hotels.Where(m=>m.Id==id).FirstOrDefaultAsync());
        }
        [HttpPost]
        public async Task<IActionResult> PostHotel([FromBody] Hotel hotel)
        {
            if(ModelState.IsValid)
            {
                await api.AddAsync(hotel);
                await api.SaveChangesAsync();
                return CreatedAtAction("GetHotels", new { id = hotel.Id },hotel);
            }
            else
            {
                return NoContent();
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHotel([FromRoute]int id,[FromBody] Hotel hotel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != hotel.Id)
            {
                return BadRequest();
            }

            try
            {
                api.hotels.Update(hotel);
                await api.SaveChangesAsync();
                return Ok(hotel);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await api.hotels.AnyAsync(m=>m.Id==id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult>  DeleteHotel([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!await api.hotels.AnyAsync(m => m.Id == id))
            {
                return NotFound();
            }

            var customer = await api.hotels.SingleAsync(a => a.Id == id);
            api.hotels.Remove(customer);
            await api.SaveChangesAsync();

            return Ok();
        }

    }
}