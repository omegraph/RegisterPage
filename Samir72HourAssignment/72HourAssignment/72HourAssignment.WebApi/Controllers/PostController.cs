using _72HourAssignment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace _72HourAssignment.WebApi.Controllers
{
    public class PostController : ApiController
    {
        private readonly PostDbContext _context = new PostDbContext();

        // Post (this is to create a post)
        // api/Restaurant
        [HttpPost]
        public async Task<IHttpActionResult> CreatePost([FromBody] Post model)
        {
            if (ModelState.IsValid)
            {
                // Store the model in the database
                return Ok("Your post was created!");
            }

            // Else, if the modelstate is not valid go ahead and reject it
            return BadRequest(ModelState);
        }
    }
}
