using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GenshinTianLiBattleClientUpdateService.Data;
using GenshinTianLiBattleClientUpdateService.Models;
/*
namespace GenshinTianLiBattleClientUpdateService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokensController : ControllerBase
    {
        private readonly ArtifactContext _context;

        public TokensController(ArtifactContext context)
        {
            _context = context;
        }

        // GET: api/Tokens
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Token>>> GetTokens()
        {
          if (_context.Tokens == null)
          {
              return NotFound();
          }
            return await _context.Tokens.ToListAsync();
        }

        // GET: api/Tokens/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Token>> GetToken(Guid? id)
        {
          if (_context.Tokens == null)
          {
              return NotFound();
          }
            var token = await _context.Tokens.FindAsync(id);

            if (token == null)
            {
                return NotFound();
            }

            return token;
        }

        // PUT: api/Tokens/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutToken(Guid? id, Token token)
        {
            if (id != token.Id)
            {
                return BadRequest();
            }

            _context.Entry(token).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TokenExists(id))
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

        // POST: api/Tokens
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Token>> PostToken(Token token)
        {
          if (_context.Tokens == null)
          {
              return Problem("Entity set 'ArtifactContext.Tokens'  is null.");
          }
            _context.Tokens.Add(token);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetToken", new { id = token.Id }, token);
        }

        // DELETE: api/Tokens/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteToken(Guid? id)
        {
            if (_context.Tokens == null)
            {
                return NotFound();
            }
            var token = await _context.Tokens.FindAsync(id);
            if (token == null)
            {
                return NotFound();
            }

            _context.Tokens.Remove(token);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TokenExists(Guid? id)
        {
            return (_context.Tokens?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
*/