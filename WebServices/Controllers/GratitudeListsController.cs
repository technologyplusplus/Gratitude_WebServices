using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebServices.Models
{
    [Produces("application/json")]
    [Route("api/GratitudeLists")]
    public class GratitudeListsController : Controller
    {
        private readonly WebServicesContext _context;

        public GratitudeListsController(WebServicesContext context)
        {
            _context = context;
        }

        // GET: api/GratitudeLists
        [HttpGet]
        public IEnumerable<GratitudeList> GetGratitudeList()
        {
            return _context.GratitudeList;
        }

        // GET: api/GratitudeLists/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetGratitudeList([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var gratitudeList = await _context.GratitudeList.SingleOrDefaultAsync(m => m.ListId == id);

            if (gratitudeList == null)
            {
                return NotFound();
            }

            return Ok(gratitudeList);
        }

        // PUT: api/GratitudeLists/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGratitudeList([FromRoute] int id, [FromBody] GratitudeList gratitudeList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != gratitudeList.ListId)
            {
                return BadRequest();
            }

            _context.Entry(gratitudeList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GratitudeListExists(id))
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

        // POST: api/GratitudeLists
        [HttpPost]
        public async Task<IActionResult> PostGratitudeList([FromBody] GratitudeList gratitudeList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.GratitudeList.Add(gratitudeList);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGratitudeList", new { id = gratitudeList.ListId }, gratitudeList);
        }

        // DELETE: api/GratitudeLists/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGratitudeList([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var gratitudeList = await _context.GratitudeList.SingleOrDefaultAsync(m => m.ListId == id);
            if (gratitudeList == null)
            {
                return NotFound();
            }

            _context.GratitudeList.Remove(gratitudeList);
            await _context.SaveChangesAsync();

            return Ok(gratitudeList);
        }

        private bool GratitudeListExists(int id)
        {
            return _context.GratitudeList.Any(e => e.ListId == id);
        }
    }
}