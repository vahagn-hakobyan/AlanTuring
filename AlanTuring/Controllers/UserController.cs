using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlanTuring.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
#region UserController

namespace AlanTuring.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly Alan_TuringContext _baza;
        #endregion

        public UserController(Alan_TuringContext baza)
        {
            _baza = baza;
            if (_baza.Users.Count() == 0)
            {
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                _baza.Users.Add(new User { FirstName = "Item1" });
                _baza.SaveChanges();
            }

        }

        #region snippet_GetAll
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUserItems()
        {
            return await _baza.Users.ToListAsync();
        }
        #region snippet_GetByID
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUserItem(long id)
        {

            var todoItem = await _baza.Users.FindAsync(id);
            if (todoItem == null)
            {
                return NotFound();
            }
            return todoItem;
        }
        #endregion
        #endregion

        #region snippet_Create
        [HttpPost]
        public async Task<ActionResult<User>> PostUserItem(User item)
        {
            //item.Id = 7;
            _baza.Users.Add(item);
            await _baza.SaveChangesAsync();
            // return Ok(item);
            return CreatedAtAction(nameof(GetUserItem), new { id = item.Id }, item);
        }
        #endregion
        #region snippet_Update
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserItem(long id, User item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _baza.Entry(item).State = EntityState.Modified;
            await _baza.SaveChangesAsync();

            return NoContent();
        }
        #endregion
        #region snippet_Delete

        //snippet_Delete
        // DELETE: api/Todo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserItem(long id)
        {
            var todoItem = await _baza.Users.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            _baza.Users.Remove(todoItem);
            await _baza.SaveChangesAsync();

            return NoContent();
        }
        #endregion
    }
}